using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace back_end
{
    public class Tutor : Employee
    {
        private uint _numberOfClasses, _experience;

        public uint NumberOfClasses
        {
            get { return _numberOfClasses; }
            set { _numberOfClasses = value; }
        }

        public uint Experience
        {
            get { return _experience; }
            set { _experience = value; }
        }
    }
}
