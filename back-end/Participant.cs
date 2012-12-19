using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace back_end
{
    public class Participant : Person
    {
        private int _id;
        private string _workCondition;
        
        public Participant()
        {
            
        }

        public string WorkCondition
        {
            set { _workCondition = value; }
            get { return _workCondition; }
        }

        public override void Update()
        {
            //Skal være der som en del af interface
        }
    }
}
