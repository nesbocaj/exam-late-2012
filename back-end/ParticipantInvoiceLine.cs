using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace back_end
{
    class ParticipantInvoiceLine : Participant
    {
        private int _ParticipantId;
        private int _CourseInvoiceId;
        private int _CourseId;
        private int _personId;
        private double _subtotal;


        public ParticipantInvoiceLine()
        {

        }

        public int ParticipantId
        {
            set { _ParticipantId = value; }
            get { return _ParticipantId; }
        }

        public int CourseInvoiceId
        {
            set { _CourseInvoiceId = value; }
            get { return _CourseInvoiceId; }
        }

        public int CourseId
        {
            set { _CourseId = value; }
            get { return _CourseId; }
        }

        public double subtotal
        {
            set { _subtotal = value; }
            get { return _subtotal; }
        }

    }
}


