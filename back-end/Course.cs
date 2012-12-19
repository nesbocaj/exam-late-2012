using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace back_end
{
    public class Course : IModel
    {
        private int _id;

        public Course()
        {
            
        }

        public int ID
        {
            set { _id = value; }
            get { return _id;}
        }

        public void Update()
        {

        }
    }
}
