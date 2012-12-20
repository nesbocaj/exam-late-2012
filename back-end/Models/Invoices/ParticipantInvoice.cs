using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace back_end
{
    public class ParticipantInvoice : IModel
    {
        private uint _id, _personId;
        private double _total, _paid;
        private Dictionary<int, ParticipantInvoiceLine> _invoiceLine;

        public ParticipantInvoice()
        {

        }

        public uint ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public uint ParticipantID
        {
            get { return _personId; }
            set { _personId = value; }
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

        public ParticipantInvoiceLine GetInvoiceLineAtIndex(int i)
        {
            return _invoiceLine[i];
        }

        public void Add(ParticipantInvoiceLine tmp)
        {
            int id = (int)typeof(ParticipantInvoiceLine).GetProperty("ID").GetValue(tmp, null);
            _invoiceLine.Add(id, tmp);
        }

        public void Update()
        {

        }
    }
}
