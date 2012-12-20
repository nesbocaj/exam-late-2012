using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace back_end
{
    class ClassInvoiceLine: IModel
    {
        private int _ClassInvoiceId; private int _PersonId;
        private  double _subtotal;

        public ClassInvoiceLine()
        {

        }
        
        public int ClassInvoiceId
        {
            set { _ClassInvoiceId = value; }
            get { return _ClassInvoiceId + _PersonId;}
        }

        public int PersonId
        {
            set { _PersonId = value; }
            get { return _PersonId; }
        }

        public double PersonSubtotal
        {
            set { _subtotal = value;}
            get { return _subtotal;}
        }

        public void Update()
        {
    }
        }
}
