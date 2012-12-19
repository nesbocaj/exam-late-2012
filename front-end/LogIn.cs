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
        
        public LogIn()
        {
            InitializeComponent();
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {

            byte[] hash = _security.ComputeHash(PasswordBox.Text, UserBox.Text, "Derp");
        }
    }
}
