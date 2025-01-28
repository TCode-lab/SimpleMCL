namespace SimpleMCL.View
{
    partial class AssemblyCreateDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            CancelButton = new Button();
            CreateButoon = new Button();
            assemblyNameField = new TextBox();
            panel1 = new Panel();
            alphaBox = new CheckBox();
            betaBox = new CheckBox();
            snapshotBox = new CheckBox();
            releaseBox = new CheckBox();
            versionsList = new ListBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Location = new Point(352, 120);
            button1.Name = "button1";
            button1.Size = new Size(100, 100);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(352, 286);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(100, 23);
            CancelButton.TabIndex = 1;
            CancelButton.Text = "Отмена";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // CreateButoon
            // 
            CreateButoon.Location = new Point(352, 255);
            CreateButoon.Name = "CreateButoon";
            CreateButoon.Size = new Size(100, 25);
            CreateButoon.TabIndex = 2;
            CreateButoon.Text = "Создать";
            CreateButoon.UseVisualStyleBackColor = true;
            CreateButoon.Click += CreateButoon_Click;
            // 
            // assemblyNameField
            // 
            assemblyNameField.Location = new Point(352, 226);
            assemblyNameField.MaxLength = 12;
            assemblyNameField.Name = "assemblyNameField";
            assemblyNameField.Size = new Size(100, 23);
            assemblyNameField.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(alphaBox);
            panel1.Controls.Add(betaBox);
            panel1.Controls.Add(snapshotBox);
            panel1.Controls.Add(releaseBox);
            panel1.Location = new Point(352, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(100, 100);
            panel1.TabIndex = 8;
            // 
            // alphaBox
            // 
            alphaBox.Location = new Point(3, 75);
            alphaBox.Name = "alphaBox";
            alphaBox.Size = new Size(90, 18);
            alphaBox.TabIndex = 3;
            alphaBox.Text = "alpha";
            alphaBox.UseVisualStyleBackColor = true;
            alphaBox.CheckedChanged += alphaBox_CheckedChanged;
            // 
            // betaBox
            // 
            betaBox.Location = new Point(3, 51);
            betaBox.Name = "betaBox";
            betaBox.Size = new Size(90, 18);
            betaBox.TabIndex = 2;
            betaBox.Text = "beta";
            betaBox.UseVisualStyleBackColor = true;
            betaBox.CheckedChanged += betaBox_CheckedChanged;
            // 
            // snapshotBox
            // 
            snapshotBox.Location = new Point(3, 27);
            snapshotBox.Name = "snapshotBox";
            snapshotBox.Size = new Size(90, 18);
            snapshotBox.TabIndex = 1;
            snapshotBox.Text = "snapshots";
            snapshotBox.UseVisualStyleBackColor = true;
            snapshotBox.CheckedChanged += snapshotBox_CheckedChanged;
            // 
            // releaseBox
            // 
            releaseBox.Location = new Point(3, 3);
            releaseBox.Name = "releaseBox";
            releaseBox.Size = new Size(90, 18);
            releaseBox.TabIndex = 0;
            releaseBox.Text = "release";
            releaseBox.UseVisualStyleBackColor = true;
            releaseBox.CheckedChanged += releaseBox_CheckedChanged;
            // 
            // versionsList
            // 
            versionsList.FormattingEnabled = true;
            versionsList.IntegralHeight = false;
            versionsList.ItemHeight = 15;
            versionsList.Location = new Point(12, 12);
            versionsList.Name = "versionsList";
            versionsList.Size = new Size(334, 297);
            versionsList.TabIndex = 9;
            // 
            // AssemblyCreateForm
            // 
            AcceptButton = CreateButoon;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 321);
            Controls.Add(versionsList);
            Controls.Add(panel1);
            Controls.Add(assemblyNameField);
            Controls.Add(CreateButoon);
            Controls.Add(CancelButton);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "AssemblyCreateForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            FormClosed += AssemblyCreateDialog_FormClosed;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button CancelButton;
        private Button CreateButoon;
        private TextBox assemblyNameField;
        private Panel panel1;
        private ListBox versionsList;
        private CheckBox alphaBox;
        private CheckBox betaBox;
        private CheckBox snapshotBox;
        private CheckBox releaseBox;
    }
}