using Microsoft.VisualBasic.Devices;
using SimpleMCL.Controller.Assemblies;
using SimpleMCL.Model;

namespace SimpleMCL.View
{
    public partial class AssemblySettingsForm : Form
    {
        private static uint computerMemorySize = uint.MaxValue; // В мегабайтах

        private readonly Assembly assembly;

        public AssemblySettingsForm(Assembly assembly)
        {
            InitializeComponent();

            this.assembly = assembly;

            if (computerMemorySize == uint.MaxValue)
            {
                ComputerInfo computerInfo = new ComputerInfo();
                computerMemorySize = Convert.ToUInt32(computerInfo.TotalPhysicalMemory / 1024 / 1024);
            }
            memoryField.Maximum = computerMemorySize;
            memoryTrackBar.Maximum = Convert.ToInt32(computerMemorySize);

            memoryField.Value = assembly.Memory;
            memoryTrackBar.Value = Convert.ToInt32(assembly.Memory);

            assemblyNameField.Text = assembly.Name;
            versionField.Text = assembly.Version;
        }

        private void memoryField_ValueChanged(object sender, EventArgs e)
        {
            memoryTrackBar.Value = Convert.ToInt32(memoryField.Value);
        }

        private void memoryTrackBar_Scroll(object sender, EventArgs e)
        {
            memoryField.Value = memoryTrackBar.Value;
        }

        private void ConfirmAndClose(object sender, EventArgs e)
        {
            assembly.Memory = Convert.ToUInt32(memoryTrackBar.Value);

            AssembliesController.EditAssemblyWithIndex(assembly.Index, assembly);
            Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
