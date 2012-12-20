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
        private uint _id, _cpr, _phone, _cellPhone, _postal, _housenumber;
        private string _firstname, _lastname, _email, _street, _city;
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

        public string Firstname
        {
            get { return _firstname; }
            set { _firstname = value; }
        }

        public string Lastname
        {
            get { return _lastname; }
            set { _lastname = value; }
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
            get { return _housenumber; }
            set { _housenumber = value; }
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

        public void Create()
        {

        }

        public void Read()
        {
            DataTable table = DatabaseCommand.Init()
                .Select(_fields, "Person")
                .Join("Person_Phone", "id", "person_id")
                .Join("Person_Email", "id", "person_id")
                .ExecuteAndReturn();
            _id = uint.Parse(table.Columns["id"].ToString());
            _cpr = uint.Parse(table.Columns["cpr"].ToString());
            _firstname = table.Columns["firstname"].ToString();
            _lastname = table.Columns["lastname"].ToString();
            _street = table.Columns["street"].ToString();
            _housenumber = uint.Parse(table.Columns["housenumber"].ToString());
            _postal = uint.Parse(table.Columns["postal"].ToString());
            _city = table.Columns["city"].ToString();
            _email = table.Columns["email"].ToString();
            _phone = uint.Parse(table.Columns["phone"].ToString());
        }

        public virtual void Update() // virtual because 2 classes inherit from person
        {

        }
    }
}
