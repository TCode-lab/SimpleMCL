
namespace SimpleMCL.View
{
    partial class AssemblySettingsForm
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
            accept = new Button();
            cancel = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            versionLabel = new Label();
            versionField = new TextBox();
            favoriteCheckBox = new CheckBox();
            descriptionLabel = new Label();
            descriptionField = new RichTextBox();
            iconSelectButton = new Button();
            assemblyNameField = new TextBox();
            memoryField = new NumericUpDown();
            assemblyNameLabel = new Label();
            memoryLabel = new Label();
            memoryTrackBar = new TrackBar();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)memoryField).BeginInit();
            ((System.ComponentModel.ISupportInitialize)memoryTrackBar).BeginInit();
            SuspendLayout();
            // 
            // accept
            // 
            accept.Location = new Point(371, 286);
            accept.Name = "accept";
            accept.Size = new Size(81, 23);
            accept.TabIndex = 1;
            accept.Text = "Применить";
            accept.UseVisualStyleBackColor = true;
            accept.Click += ConfirmAndClose;
            // 
            // cancel
            // 
            cancel.Location = new Point(290, 286);
            cancel.Name = "cancel";
            cancel.Size = new Size(75, 23);
            cancel.TabIndex = 3;
            cancel.Text = "Отмена";
            cancel.UseVisualStyleBackColor = true;
            cancel.Click += cancel_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(440, 268);
            tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(versionLabel);
            tabPage1.Controls.Add(versionField);
            tabPage1.Controls.Add(favoriteCheckBox);
            tabPage1.Controls.Add(descriptionLabel);
            tabPage1.Controls.Add(descriptionField);
            tabPage1.Controls.Add(iconSelectButton);
            tabPage1.Controls.Add(assemblyNameField);
            tabPage1.Controls.Add(memoryField);
            tabPage1.Controls.Add(assemblyNameLabel);
            tabPage1.Controls.Add(memoryLabel);
            tabPage1.Controls.Add(memoryTrackBar);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(432, 240);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Основные";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // versionLabel
            // 
            versionLabel.AutoSize = true;
            versionLabel.Location = new Point(327, 9);
            versionLabel.Name = "versionLabel";
            versionLabel.Size = new Size(49, 15);
            versionLabel.TabIndex = 11;
            versionLabel.Text = "Версия:";
            // 
            // versionField
            // 
            versionField.Enabled = false;
            versionField.Location = new Point(327, 27);
            versionField.Name = "versionField";
            versionField.Size = new Size(99, 23);
            versionField.TabIndex = 10;
            // 
            // favoriteCheckBox
            // 
            favoriteCheckBox.AutoSize = true;
            favoriteCheckBox.Enabled = false;
            favoriteCheckBox.Location = new Point(6, 112);
            favoriteCheckBox.Name = "favoriteCheckBox";
            favoriteCheckBox.Size = new Size(86, 19);
            favoriteCheckBox.TabIndex = 9;
            favoriteCheckBox.Text = "Избранная";
            favoriteCheckBox.UseVisualStyleBackColor = true;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(112, 53);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(56, 15);
            descriptionLabel.TabIndex = 8;
            descriptionLabel.Text = "Заметки:";
            // 
            // descriptionField
            // 
            descriptionField.Enabled = false;
            descriptionField.Location = new Point(112, 71);
            descriptionField.Name = "descriptionField";
            descriptionField.Size = new Size(314, 83);
            descriptionField.TabIndex = 7;
            descriptionField.Text = "";
            // 
            // iconSelectButton
            // 
            iconSelectButton.Enabled = false;
            iconSelectButton.Location = new Point(6, 6);
            iconSelectButton.Name = "iconSelectButton";
            iconSelectButton.Size = new Size(100, 100);
            iconSelectButton.TabIndex = 6;
            iconSelectButton.UseVisualStyleBackColor = true;
            // 
            // assemblyNameField
            // 
            assemblyNameField.Enabled = false;
            assemblyNameField.Location = new Point(112, 27);
            assemblyNameField.Name = "assemblyNameField";
            assemblyNameField.Size = new Size(209, 23);
            assemblyNameField.TabIndex = 5;
            // 
            // memoryField
            // 
            memoryField.Location = new Point(355, 160);
            memoryField.Maximum = new decimal(new int[] { 512, 0, 0, 0 });
            memoryField.Minimum = new decimal(new int[] { 512, 0, 0, 0 });
            memoryField.Name = "memoryField";
            memoryField.Size = new Size(71, 23);
            memoryField.TabIndex = 4;
            memoryField.Value = new decimal(new int[] { 512, 0, 0, 0 });
            memoryField.ValueChanged += memoryField_ValueChanged;
            // 
            // assemblyNameLabel
            // 
            assemblyNameLabel.AutoSize = true;
            assemblyNameLabel.Location = new Point(112, 9);
            assemblyNameLabel.Name = "assemblyNameLabel";
            assemblyNameLabel.Size = new Size(77, 15);
            assemblyNameLabel.TabIndex = 3;
            assemblyNameLabel.Text = "Имя сборки:";
            // 
            // memoryLabel
            // 
            memoryLabel.AutoSize = true;
            memoryLabel.Location = new Point(6, 168);
            memoryLabel.Name = "memoryLabel";
            memoryLabel.Size = new Size(220, 15);
            memoryLabel.TabIndex = 1;
            memoryLabel.Text = "Выделение ОЗУ (оперативной памяти)";
            // 
            // memoryTrackBar
            // 
            memoryTrackBar.LargeChange = 512;
            memoryTrackBar.Location = new Point(6, 189);
            memoryTrackBar.Maximum = 512;
            memoryTrackBar.Minimum = 512;
            memoryTrackBar.Name = "memoryTrackBar";
            memoryTrackBar.Size = new Size(420, 45);
            memoryTrackBar.SmallChange = 512;
            memoryTrackBar.TabIndex = 0;
            memoryTrackBar.Value = 512;
            memoryTrackBar.Scroll += memoryTrackBar_Scroll;
            // 
            // AssemblySettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 321);
            Controls.Add(tabControl1);
            Controls.Add(cancel);
            Controls.Add(accept);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AssemblySettingsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AssemblySettingsForm";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)memoryField).EndInit();
            ((System.ComponentModel.ISupportInitialize)memoryTrackBar).EndInit();
            ResumeLayout(false);
        }


        #endregion
        private Button accept;
        private Button cancel;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label memoryLabel;
        private TrackBar memoryTrackBar;
        private TextBox assemblyNameField;
        private NumericUpDown memoryField;
        private Label assemblyNameLabel;
        private Label descriptionLabel;
        private RichTextBox descriptionField;
        private Button iconSelectButton;
        private CheckBox favoriteCheckBox;
        private Label versionLabel;
        private TextBox versionField;
    }
}