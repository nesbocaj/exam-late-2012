using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace back_end.Models
{
    public class Tutor : Employee
    {
        private int _numberOfClasses, _experience;

        public int NumberOfClasses
        {
            get { return _numberOfClasses; }
            set { _numberOfClasses = value; }
        }

        public int Experience
        {
            get { return _experience; }
            set { _experience = value; }
            }
    }
}
