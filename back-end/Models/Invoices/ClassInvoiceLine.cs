using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace back_end
{
    class ClassInvoiceLine: IModel
    {
        private uint _invoiceId, _personId, _id;
        private double _subtotal;

        public ClassInvoiceLine()
        {

        }
        
        public uint ID
        {
            get { return _id; }
            set { _id = Convert.ToUInt32("" + _invoiceId.ToString() + _personId.ToString()); }
        }

        public uint ClassInvoiceId
        {
            set { _invoiceId = value; }
            get { return _invoiceId + _personId;}
        }

        public uint PersonId
        {
            set { _personId = value; }
            get { return _personId; }
        }

        public double Subtotal
        {
            set { _subtotal = value;}
            get { return _subtotal;}
        }

        public void Update()
        {

        }
    }
}
