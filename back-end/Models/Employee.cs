using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using datalayer;
using System.Data;

namespace back_end
{
    public abstract class Person : IModel
    {
        private uint _id, _cpr, _phone, _cellPhone, _postal, _houseNumber;
        private string _firstName, _lastName, _email, _street, _city;
        private string[] _fields;

        public Person()
        {
            _fields = new string[] {
                "id",
                "cpr",
                "firstname",
                "lastname",
                "street",
                "housenumber",
                "postal",
                "city",
                "email",
                "phone"
            };
        }

        public uint ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public uint CPR
        {
            get { return _cpr; }
            set { _cpr = value; }
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

        public string Street
        {
            get { return _street; }
            set { _street = value; }
        }

        public uint HouseNumber
        {
            get { return _houseNumber; }
            set { _houseNumber = value; }
        }

        public uint PostalCode
        {
            get { return _postal; }
            set { _postal = value; }
        }

        public string City
        {
            get { return _city; }
            set { _city = value; }
        }

        public void Read()
        {
            DataTable table = DatabaseCommand.Init()
                .Select(_fields, "Person")
                .Join("Person_Phone", "id", "person_id")
                .Join("Person_Email", "id", "person_id")
                .ExecuteAndReturn();
            _id = uint.Parse(table.Columns["id"].ToString());

        }

        public virtual void Update() // virtual because 2 classes inherit from person
        {

        }
    }
}
