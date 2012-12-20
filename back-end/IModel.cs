using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using datalayer;

namespace back_end
{
    public interface IModel
    {
        uint ID
        {
            get;
            set;
        }

        void Update();
    }
}
