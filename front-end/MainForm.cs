using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam_late_2012
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
            EmployeeControl.AddButton.Click += AddEmployee_Click;

        }

        public void AddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployee addEmp = new AddEmployee();

            addEmp.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LogIn loginWindow = new LogIn();
            loginWindow.ShowDialog();
        }
    }
}
