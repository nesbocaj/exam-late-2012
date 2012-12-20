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
        protected uint _id, _cpr, _phone, _cellPhone, _postal, _housenumber;
        protected string _firstname, _lastname, _email, _street, _city;
        protected string[] _fields;

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

        public virtual void Create()
        {

        }

        public virtual void Read()
        {
            DataTable table = DatabaseCommand.Init()
                .Select(_fields, "Person")
                .Join("Person_Phone", "id", "person_id")
                .Join("Person_Email", "id", "person_id")
                .ExecuteAndReturn();
            _id = uint.Parse(table.Rows[0]["id"].ToString());
            _cpr = uint.Parse(table.Rows[0]["cpr"].ToString());
            _firstname = table.Rows[0]["firstname"].ToString();
            _lastname = table.Rows[0]["lastname"].ToString();
            _street = table.Rows[0]["street"].ToString();
            _housenumber = uint.Parse(table.Rows[0]["housenumber"].ToString());
            _postal = uint.Parse(table.Rows[0]["postal"].ToString());
            _city = table.Rows[0]["city"].ToString();
            _email = table.Rows[0]["email"].ToString();
            _phone = uint.Parse(table.Rows[0]["phone"].ToString());
            _cellPhone = uint.Parse(table.Rows[1]["phone"].ToString());
        }

        public virtual void Update() // virtual because 2 classes inherit from person
        {
            
        }

        public virtual void Delete()
        {
            DatabaseCommand.Init()
                .Delete("Person")
                .Where("id", "=", _id)
                .Execute();
        }
    }
}
