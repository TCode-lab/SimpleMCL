using SimpleMCL.Model.UI;

namespace SimpleMCL
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ToolStripSeparator toolStripSeparator1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            toolStrip1 = new ToolStrip();
            FileButton = new ToolStripDropDownButton();
            createAssemblyButton = new ToolStripButton();
            ProfileButton = new ToolStripButton();
            DebugButton = new ToolStripLabel();
            statusStrip1 = new StatusStrip();
            progressBar = new ToolStripProgressBar();
            pictureBox1 = new PictureBox();
            assemblyNameLabel = new Label();
            gameButton = new Button();
            assembliesPanel = new FlowLayoutPanel();
            settingsButton = new Button();
            deleteButton = new Button();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { FileButton, createAssemblyButton, ProfileButton, toolStripSeparator1, DebugButton });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(464, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // FileButton
            // 
            FileButton.Enabled = false;
            FileButton.Margin = new Padding(3, 1, 0, 2);
            FileButton.Name = "FileButton";
            FileButton.Size = new Size(49, 22);
            FileButton.Text = "Файл";
            // 
            // createAssemblyButton
            // 
            createAssemblyButton.Name = "createAssemblyButton";
            createAssemblyButton.Size = new Size(105, 22);
            createAssemblyButton.Text = "Добавить сборку";
            createAssemblyButton.Click += createAssemblyButton_Click;
            // 
            // ProfileButton
            // 
            ProfileButton.Alignment = ToolStripItemAlignment.Right;
            ProfileButton.AutoSize = false;
            ProfileButton.Enabled = false;
            ProfileButton.Image = (Image)resources.GetObject("ProfileButton.Image");
            ProfileButton.ImageAlign = ContentAlignment.MiddleLeft;
            ProfileButton.ImageTransparentColor = Color.Magenta;
            ProfileButton.Margin = new Padding(0, 1, 12, 2);
            ProfileButton.Name = "ProfileButton";
            ProfileButton.Size = new Size(100, 22);
            ProfileButton.Text = "Профиль";
            // 
            // DebugButton
            // 
            DebugButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            DebugButton.Name = "DebugButton";
            DebugButton.Size = new Size(0, 22);
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { progressBar });
            statusStrip1.Location = new Point(0, 299);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(464, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // progressBar
            // 
            progressBar.Margin = new Padding(11, 3, 1, 3);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(334, 16);
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Enabled = false;
            pictureBox1.Location = new Point(352, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // assemblyNameLabel
            // 
            assemblyNameLabel.Location = new Point(352, 131);
            assemblyNameLabel.Name = "assemblyNameLabel";
            assemblyNameLabel.Size = new Size(100, 23);
            assemblyNameLabel.TabIndex = 4;
            assemblyNameLabel.Text = "...";
            assemblyNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gameButton
            // 
            gameButton.Location = new Point(352, 157);
            gameButton.Name = "gameButton";
            gameButton.Size = new Size(100, 31);
            gameButton.TabIndex = 5;
            gameButton.Text = "Играть";
            gameButton.UseVisualStyleBackColor = true;
            gameButton.Click += gameButton_Click;
            // 
            // assembliesPanel
            // 
            assembliesPanel.BorderStyle = BorderStyle.Fixed3D;
            assembliesPanel.Location = new Point(12, 28);
            assembliesPanel.Name = "assembliesPanel";
            assembliesPanel.Size = new Size(334, 268);
            assembliesPanel.TabIndex = 6;
            // 
            // settingsButton
            // 
            settingsButton.Location = new Point(352, 194);
            settingsButton.Name = "settingsButton";
            settingsButton.Size = new Size(100, 23);
            settingsButton.TabIndex = 7;
            settingsButton.Text = "Настройки";
            settingsButton.UseVisualStyleBackColor = true;
            settingsButton.Click += settingsButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(352, 273);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(100, 23);
            deleteButton.TabIndex = 8;
            deleteButton.Text = "Удалить";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 321);
            Controls.Add(deleteButton);
            Controls.Add(settingsButton);
            Controls.Add(assembliesPanel);
            Controls.Add(gameButton);
            Controls.Add(assemblyNameLabel);
            Controls.Add(pictureBox1);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SimpleMCL";
            FormClosed += Form1_Closing;
            Load += Form1_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStrip toolStrip1;
        private ToolStripDropDownButton FileButton;
        private StatusStrip statusStrip1;
        private ToolStripProgressBar progressBar;
        private PictureBox pictureBox1;
        private Label assemblyNameLabel;
        private Button gameButton;
        private ToolStripButton createAssemblyButton;
        private ToolStripButton ProfileButton;
        private ToolStripLabel DebugButton;
        private FlowLayoutPanel assembliesPanel;
        private Button settingsButton;
        private Button deleteButton;
    }
}
