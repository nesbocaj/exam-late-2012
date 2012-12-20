using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using datalayer;

namespace back_end
{
    public abstract class Person : IModel
    {
        private int _id, _ssn, _postal, _houseNumber;
        private uint _phone, _cellPhone;
        private string _firstName, _lastName, _email, _city;

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

        public uint Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        public uint CellPhone
        {
            get { return _cellPhone; }
            set { _cellPhone = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
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

        public string City
        {
            get { return _city; }
            set { _city = value; }
        }

        public void Read()
        {
            
        }

        public virtual void Update() // virtual because 2 classes inherit from person
        {
            
        }
    }
}
