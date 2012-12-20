using datalayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using datalayer;
using System.Data;
namespace back_end
{
    public class Employee : Person
    {
        protected uint _salaryRate, _workingHours;
        protected string _accessword, _initials, _position;
        protected string[] _employeeFields;

        public Employee()
        {
            _employeeFields = new string[] {
            "name",
            "initials",
            "accessword",
            "working_hours"
            };
        }

        public string Position
        {
            set { _position = value;}
            get { return _position; }
        }

        public uint SalaryRate
        {
            set { _salaryRate = value;}
            get { return _salaryRate; }
        }

        public uint WorkingHours
        {
            set { _workingHours = value;}
            get { return _workingHours; }
        }

        public string AccessWord
        {
            set { _accessword = value;}
            get { return _accessword; }
        }

        public string initials
        {
            set { _initials = value; }
            get { return _initials; }
        }

        public override void Read()
        {
            base.Read();
            DataTable employeeTable = DatabaseCommand.Init()
                .Select(_fields, "Employee")
                .Join("Employee_Position", "position_id", "id")
                .Join("Salaryrate", "salaryrate_id", "id")
                .ExecuteAndReturn();
            //_salaryRate = uint.Parse("Salaryrate")
            _position = employeeTable.Columns["name"].ToString();
            _initials = employeeTable.Columns["initials"].ToString();
            _accessword = employeeTable.Columns["accessword"].ToString();
            _workingHours = uint.Parse(employeeTable.Columns["working_hours"].ToString());
            
        }

        public override void Update()
        {
            // Has to be there as a part of an interface
        }
    }
}
