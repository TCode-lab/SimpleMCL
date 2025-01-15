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
    public partial class AssemblyDeleteDialog : Form
    {
        public event Action DeleteSubmitted;

        public AssemblyDeleteDialog()
        {
            InitializeComponent();
        }
        
        public void SetMessage(string message)
        {
            messageLabel.Text = message;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            DeleteSubmitted?.Invoke();
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
