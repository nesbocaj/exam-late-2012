using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace back_end
{
    class Participant : IModel
    {
        private int _id;
        private string _workCondition;
        
        public Participant()
        {
            
        }

        public int ID
        {
            get { return _id; }
        }

        public string WorkCondition
        {
            get { return _workCondition; }
        }
    }
}
