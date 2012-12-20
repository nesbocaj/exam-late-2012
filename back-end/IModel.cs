using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using datalayer;

namespace back_end
{
    interface IModel
    {
        int ID
        {
            get;
            set;
        }

        void Update();
    }
}
