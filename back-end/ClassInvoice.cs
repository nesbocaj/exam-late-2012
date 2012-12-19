using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace back_end
{
    public class ClassInvoice : IModel
    {
        private int _id, _classId;
        private double _total, _paid;
        //private Dictionary<int, ClassInvoiceLine> invoiceLine;

        public ClassInvoice()
        {

        }

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public int ClassID
        {
            get { return _classId; }
            set { _classId = value; }
        }

        public double Total
        {
            get { return _total; }
            set { _total = value; }
        }

        public double Paid
        {
            get { return _paid; }
            set { _paid = value; }
        }

        public void Update()
        {

        }
    }
}
