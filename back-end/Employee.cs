using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace back_end
{
    public class Employee : Person
    {
        private int _id, _position, _salaryRate, _workingHours;
        private string _accessword;

        public Employee()
        {

        }

        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }

        public int Position
        {
            set { _position = value;}
            get { return _position;}
        }

        public int SalaryRate
        {
            set { _salaryRate = value;}
            get { return _salaryRate;}
        }

        public int WorkingHours
        {
            set { _workingHours = value;}
            get { return _workingHours; }
        }

        public string AccessWord
        {
            set { _accessword = value;}
            get { return _accessword; }
        }

        public void Update()
        {
           //Skal være der som en del af interface
        }
    }
}
