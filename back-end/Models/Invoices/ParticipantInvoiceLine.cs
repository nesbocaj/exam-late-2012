using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace back_end
{
    public class ParticipantInvoiceLine : IModel
    {
        private uint _participantId, _invoiceId, _id, _personId;
        private double _subtotal;

        public ParticipantInvoiceLine()
        {

        }

        public uint ID
        {
            // concatenating the 2 numbers to get a common id, the "" is there to make sure it acts as a string rather than trying to play clever and skip it all by just adding
            set { _id = Convert.ToUInt32("" + _invoiceId.ToString() + _personId.ToString()); }
            get { return _id; }
        }

        public uint ParticipantID
        {
            set { _participantId = value; }
            get { return _participantId; }
        }

        public uint CourseInvoiceID
        {
            set { _invoiceId = value; }
            get { return _invoiceId; }
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


