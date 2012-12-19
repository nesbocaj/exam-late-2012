using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using back_end;

namespace exam_late_2012
{
    public partial class LogIn : Form
    {
        private Security _security = Security.Instance;

        private MainForm _parentWindow = null;

        public LogIn(MainForm window)
        {
            _parentWindow = window;
            InitializeComponent();
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            string username = UserBox.Text;
            byte[] hash = _security.ComputeHash(PasswordBox.Text, username, "Derp");
        }

        private void LogIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_parentWindow == null)
                MessageBox.Show("Parent window not present", "Warning!");
            else
                _parentWindow.Close();   
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
