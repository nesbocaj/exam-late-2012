using datalayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace back_end
{
    public class Employee : Person
    {
        protected uint _position, _salaryRate, _workingHours;
        protected string _accessword, _initials;

        public Employee()
        {

        }

        public uint Position
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

        public override void Update()
        {
            // Has to be there as a part of an interface
        }
    }
}
