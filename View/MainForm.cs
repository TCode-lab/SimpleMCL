using SimpleMCL.Controller;
using SimpleMCL.Controller.Assemblies;
using SimpleMCL.Controller.Settings;
using SimpleMCL.Model;
using SimpleMCL.Model.UI;
using SimpleMCL.View;
using System.Resources;

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
            if (sender is AssemblyCard card && LauncherController.Status == LauncherStatus.waiting)
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
                    assemblyCard.TextAlign = ContentAlignment.BottomCenter;
                    //assemblyCard.BackgroundImage = 
                    assemblyCard.BackgroundImageLayout = ImageLayout.Zoom;
                    assemblyCard.Text = $"{assembly.Name}\n({assembly.Version})";
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

            if (LauncherController.Status == LauncherStatus.inGame)
            {
                gameButton.Enabled = true;
                gameButton.Text = "Оставновить";
            }
            else
            {
                gameButton.Text = "Играть";
            }
        }

        private void createAssemblyButton_Click(object sender, EventArgs e)
        {
            var createForm = new AssemblyCreateDialog();
            createForm.DataSubmitted += CreateAssembly;
            createForm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            AssembliesController.Read();
            LauncherController.progressBar = progressBar;
            LauncherController.statusLabel = toolStripStatusLabel;
            LauncherController.LockAssemblyControlAction += LockAssemblyControl;
            UpdateAssembliesCards();
        }

        private void LockAssemblyControl(bool flag)
        {
            if (flag == true)
            {
                if (currentAssembly == null) { return; }
                var crutch = currentAssembly;
                currentAssembly = null;
                UpdateAssemblyControl();
                currentAssembly = crutch;
                assemblyNameLabel.Text = currentAssembly.Name;
            }
            else
            {
                UpdateAssemblyControl();
            }
        }

        private void MainForm_Closing(object sender, FormClosedEventArgs e)
        {
            AssembliesController.Write();
            ConfigurationsJson.Write(Configurations.activeConf);
        }

        private async void AssemblyTurnClick(object sender, EventArgs e)
        {
            if (LauncherController.Status == LauncherStatus.inGame)
            {
                LauncherController.CloseProcess();
                return;
            }
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
