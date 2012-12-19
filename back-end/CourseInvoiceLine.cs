using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace back_end
{
    class CourseInvoiceLine
    {
        private int _CourseInvoiceId; private int _PersonId;
        private double _subtotal;

        public CourseInvoiceLine()
        {

        }

        public int CourseInvoiceId
        {
            set { _CourseInvoiceId = value; }
            get { return _CourseInvoiceId; }
        }

        public int PersonId
        {
            set { _PersonId = value; }
            get { return _PersonId; }
        }

        public double Subtotal
        {
            set { _subtotal = value; }
            get { return _subtotal; }
        }
    }
}
