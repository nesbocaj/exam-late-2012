using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace back_end
{
    public class ParticipantInvoice : IModel
    {
        private int _id, _personId;
        private double _total, _paid;
        //private Dictionary<int, ParticipantInvoiceLine> invoiceLine;

        public ParticipantInvoice()
        {

        }

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public int ParticipantID
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

        public void Update()
        {

        }
    }
}
