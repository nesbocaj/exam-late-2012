using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace back_end
{
    class Person : IModel
    {
        private int _id;

        public Person()
        {

        }

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public void Update()
        {

        }
    }
}
