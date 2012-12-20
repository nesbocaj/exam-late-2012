using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace back_end
{
    class ClassInvoiceLine: IModel
    {
        private int _invoiceId; private int _personId, _id;
        private  double _subtotal;

        public ClassInvoiceLine()
        {

        }
        
        public int ID
        {
            get { return _id; }
            set { _id = Convert.ToInt32("" + _invoiceId.ToString() + _personId.ToString()); }
        }

        public int ClassInvoiceId
        {
            set { _invoiceId = value; }
            get { return _invoiceId + _personId;}
        }

        public int PersonId
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
