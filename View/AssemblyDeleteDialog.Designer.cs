namespace SimpleMCL.View
{
    partial class AssemblyDeleteDialog
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
            confirmButton = new Button();
            cancelButton = new Button();
            messageLabel = new Label();
            SuspendLayout();
            // 
            // confirmButton
            // 
            confirmButton.Location = new Point(193, 76);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(75, 23);
            confirmButton.TabIndex = 0;
            confirmButton.Text = "Ок";
            confirmButton.UseVisualStyleBackColor = true;
            confirmButton.Click += confirmButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(112, 76);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 1;
            cancelButton.Text = "Отмена";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // messageLabel
            // 
            messageLabel.Location = new Point(12, 9);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new Size(256, 64);
            messageLabel.TabIndex = 2;
            messageLabel.Text = "label1";
            // 
            // AssemblyDeleteDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(280, 105);
            Controls.Add(messageLabel);
            Controls.Add(cancelButton);
            Controls.Add(confirmButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AssemblyDeleteDialog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AssemblyDeleteDialog";
            ResumeLayout(false);
        }

        #endregion

        private Button confirmButton;
        private Button cancelButton;
        private Label messageLabel;
    }
}