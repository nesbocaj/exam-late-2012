using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace back_end
{
    public class Participant : IModel
    {
        private int _id;
        private string _workCondition;
        
        public Participant()
        {
            
        }

        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }

        public string WorkCondition
        {
            set { _workCondition = value; }
            get { return _workCondition; }
        }

        public void Update()
        {
            //Skal være der som en del af interface
        }
    }
}
