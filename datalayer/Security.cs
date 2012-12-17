using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace back_end
{
    class Security
    {
        private static Security _instance;
        private string _salt, _pepper;
        private SHA512 _hasher;

        private Security()
        {
            _salt = "salt";
            _pepper = "pepper";
            _hasher = SHA512Cng.Create();
        }

        public static Security Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Security();
                return _instance;
            }
        }

        public byte[] ComputeHash(string clearText)
        {
            byte[] ascii = ASCIIEncoding.ASCII.GetBytes(_salt + clearText + _pepper);
            byte[] hash = _hasher.ComputeHash(ascii);

            return hash;
        }

        public byte[] ComputeHash(string clearText, string salt, string pepper)
        {
            byte[] ascii = ASCIIEncoding.ASCII.GetBytes(_salt + clearText + _pepper);
            byte[] hash = _hasher.ComputeHash(ascii);

            return hash;
        }
    }
}
