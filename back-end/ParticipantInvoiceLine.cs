using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace back_end
{
    public class ParticipantInvoiceLine : IModel
    {
        private int _participantId;
        private int _invoiceId;
        private int _id;
        private int _personId;
        private double _subtotal;


        public ParticipantInvoiceLine()
        {

        }

        public int ParticipantID
        {
            set { _participantId = value; }
            get { return _participantId; }
        }

        public int CourseInvoiceID
        {
            set { _invoiceId = value; }
            get { return _invoiceId; }
        }

        public int ID
        {
            set { _id = _invoiceId + _personId; }
            get { return _id; }
        }

        public double Subtotal
        {
            set { _subtotal = value; }
            get { return _subtotal; }
        }

        public void Update()
        {
        }       
       }
}


