using SimpleMCL.Controller;
using SimpleMCL.Controller.Assemblies;
using SimpleMCL.Model;
using SimpleMCL.Model.UI;
using SimpleMCL.View;

namespace SimpleMCL
{
    public partial class MainForm : Form
    {
        private Assembly? currentAssembly = null;
        public MainForm()
        {
            InitializeComponent();
            UpdateAssemblyControl();
        }

        private void PickAssembly(object? sender, EventArgs e)
        {
            if (sender is AssemblyCard card)
            {
                currentAssembly = AssembliesController.GetAssemblyByIndex(card.assemblyId);
                UpdateAssemblyControl();
            }
        }

        private void UpdateAssembliesCards()
        {
            assembliesPanel.Controls.Clear();
            for (int i = 0; i < AssembliesController.AssembliesCount; i++)
            {
                var assembly = AssembliesController.GetAssemblyByIndex(i);
                if (assembly != null)
                {
                    var assemblyCard = new AssemblyCard();
                    assemblyCard.Name = $"assemblyCard_{i}";
                    assemblyCard.UseVisualStyleBackColor = true;
                    assemblyCard.Text = assembly.Name;
                    assemblyCard.assemblyId = i;
                    assemblyCard.Size = new Size(60, 60);
                    assemblyCard.Click += PickAssembly;

                    assembliesPanel.Controls.Add(assemblyCard);
                }
            }
        }

        private void CreateAssembly(AssemblyInfo data)
        {
            AssembliesController.CreateAssembly(data.Name, data.Version);
            UpdateAssembliesCards();
        }

        private void UpdateAssemblyControl()
        {
            bool isSelectedAssembly = currentAssembly != null;
            gameButton.Enabled = isSelectedAssembly;
            deleteButton.Enabled = isSelectedAssembly;
            settingsButton.Enabled = isSelectedAssembly;

            if (currentAssembly != null) { assemblyNameLabel.Text = currentAssembly.Name; }
            else { assemblyNameLabel.Text = "..."; }
        }

        private void createAssemblyButton_Click(object sender, EventArgs e)
        {
            var createForm = new AssemblyCreateDialog();
            createForm.DataSubmitted += CreateAssembly;
            createForm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AssembliesController.Read();
            LauncherController.progressBar = progressBar;
            UpdateAssembliesCards();
        }

        private void Form1_Closing(object sender, FormClosedEventArgs e)
        {
            AssembliesController.Write();
        }

        private async void gameButton_Click(object sender, EventArgs e)
        {
            if (currentAssembly != null)
            {
                await LauncherController.InstallAssembly(currentAssembly);
                await LauncherController.BuildAndStartAssembly(currentAssembly);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (currentAssembly != null)
            {
                var deleteForm = new AssemblyDeleteDialog();
                deleteForm.SetMessage($"Вы уверены, что хотите удалить сборку \"{currentAssembly.Name}\" и все её файлы?");
                deleteForm.DeleteSubmitted += deleteAssembly;
                deleteForm.ShowDialog();
            }
        }

        private void deleteAssembly()
        {
            if (currentAssembly != null)
            {
                AssembliesController.DeleteAssemblyByName(currentAssembly.Name);
                currentAssembly = null;
                UpdateAssembliesCards();
                UpdateAssemblyControl();
            }
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            if (currentAssembly != null)
            {
                var assemblySettingsForm = new AssemblySettingsForm(currentAssembly);
                assemblySettingsForm.ShowDialog();
            }
        }
    }
}
