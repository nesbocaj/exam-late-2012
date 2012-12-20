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
        private uint _position, _salaryRate, _workingHours;
        private string _accessword;

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

        public override void Update()
        {
            // Has to be there as a part of an interface
        }
    }
}
