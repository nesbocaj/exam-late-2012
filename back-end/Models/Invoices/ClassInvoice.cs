using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace back_end
{
    public class ClassInvoice : IModel
    {
        private uint _id, _classId;
        private double _total, _paid;
        //private Dictionary<int, ClassInvoiceLine> _invoiceLine;

        public ClassInvoice()
        {

        }

        public uint ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public uint ClassID
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
        /*
        public ClassInvoiceLine GetInvoiceLineAtIndex(int i)
        {
            return _invoiceLine[i];
        }

        public void Add(ClassInvoiceLine tmp)
        {
            int id = (int)typeof(ClassInvoiceLine).GetProperty("ID").GetValue(tmp, null);
            _invoiceLine.Add(id, tmp);
        }
        */
        public void Update()
        {

        }
    }
}
