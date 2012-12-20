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

        public int SSN
        {
            get { return _ssn; }
            set { _ssn = value; }
        }

        public int PostalCode
        {
            get { return _postal; }
            set { _postal = value; }
        }

        public int HouseNumber
        {
            get { return _houseNumber; }
            set { _houseNumber = value; }
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string City
        {
            get { return _city; }
            set { _city = value; }
        }

        public virtual void Update()
        {

        }
    }
}
