using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace back_end
{
    public class Person : IModel
    {
        private int _id, _ssn, _postal, _houseNumber;
        private string _firstName, _lastName, _city;

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
