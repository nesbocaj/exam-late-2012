using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace back_end
{
    class Employee : IModel
    {
        private int _id, _position, _salaryRate, _workingHours;
        private string _accessword;

        public Employee()
        {

        }

        public int ID
        {
            get
            {
                return _id;
            }
        }

        public int Position
        {
            get
            {
                return _position;
            }
        }

        public int SalaryRate
        {
            get
            {
                return _salaryRate;
            }
        }

        public int WorkingHours
        {
            get
            {
                return _workingHours;
            }
        }

        public string AccessWord
        {
            get
            {
                return _accessword;
            }
        }
    }
}
