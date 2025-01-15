using SimpleMCL.Controller.Assemblies;
using SimpleMCL.Controller.Versions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleMCL.View
{
    public struct AssemblyInfo
    {
        public required string Name;
        public required string Version;
    }

    public partial class AssemblyCreateDialog : Form
    {
        private static bool firstLaunch = true;
        public event Action<AssemblyInfo> DataSubmitted;

        public AssemblyCreateDialog()
        {
            InitializeComponent();
        }

        private void CreateButoon_Click(object sender, EventArgs e)
        {
            var versionName = versionsList.SelectedItem as string;
            var assemblyName = assemblyNameField.Text;
            bool isUniqueName = true;

            for (int i = 0; i < AssembliesController.AssembliesCount; i++)
            {
                var assembly = AssembliesController.GetAssemblyByIndex(i);
                if (assembly == null) { continue; }
                if (assemblyName == assembly.Name) { isUniqueName = false; break; }
            }

            if (assemblyName == string.Empty) { MessageBox.Show("Придумайте имя сборке."); return; }
            if (!isUniqueName) { MessageBox.Show("Данное имя уже используется."); return; }
            if (versionName == null || versionName == string.Empty) { MessageBox.Show("Выберите версию сборки."); return; }

            var result = new AssemblyInfo()
            {
                Name = assemblyName,
                Version = versionName
            };

            DataSubmitted?.Invoke(result);
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadVersionsList();
        }

        private async void LoadVersionsList()
        {
            if (AssemblyCreateDialog.firstLaunch)
            {
                var updateResult = await VersionsController.UpdateVersionsMeta();
                if (!updateResult) { MessageBox.Show("Ошибка обновления списка версий."); this.Close(); return; }
                AssemblyCreateDialog.firstLaunch = false;
            }

            versionsList.Items.Clear();
            var versions = VersionsController.GetAllVersionsMeta(
                  releaseBox.Checked
                , snapshotBox.Checked
                , betaBox.Checked
                , alphaBox.Checked
                );

            if (versions.Any())
            {
                foreach (var ver in versions)
                {
                    versionsList.Items.Add(ver.Name);
                }
            }
            else
            {
                versionsList.Items.Add("Список доступных версий пуст.");
            }
        }

        private void releaseBox_CheckedChanged(object sender, EventArgs e)
        {
            LoadVersionsList();
        }

        private void snapshotBox_CheckedChanged(object sender, EventArgs e)
        {
            LoadVersionsList();
        }

        private void betaBox_CheckedChanged(object sender, EventArgs e)
        {
            LoadVersionsList();
        }

        private void alphaBox_CheckedChanged(object sender, EventArgs e)
        {
            LoadVersionsList();
        }
    }
}
