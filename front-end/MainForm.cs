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
            ParticipantControl.AddButton.Click += AddParticipant_Click;
            CourseControl.AddButton.Click += AddCourse_Click;
            ClassControl.AddButton.Click += AddClass_Click;

            EmployeeControl.EditButton.Click += EditEmployee_Click;
            ParticipantControl.EditButton.Click += AddParticipant_Click;
            CourseControl.EditButton.Click += AddCourse_Click;
            ClassControl.EditButton.Click += AddClass_Click;
        }

        public void EditEmployee_Click(object sender, EventArgs e)
        {
            AddEmployeeForm addEmp = new AddEmployeeForm();

            addEmp.ShowForm();
        }

        public void AddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployeeForm addEmp = new AddEmployeeForm();

            addEmp.ShowForm();
        }

        public void AddParticipant_Click(object sender, EventArgs e)
        {
            AddParticipantForm addPar = new AddParticipantForm();

            addPar.ShowForm();
        }

        public void AddCourse_Click(object sender, EventArgs e)
        {
            AddCourseForm addCou = new AddCourseForm();
            addCou.ShowForm();
        }

        public void AddClass_Click(object sender, EventArgs e)
        {
            AddClassForm addCla = new AddClassForm();
            addCla.ShowForm();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            LoginForm loginWindow = new LoginForm(this);
            loginWindow.ShowDialog();
        }
    }
}
