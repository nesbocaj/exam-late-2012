using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace back_end
{
    class Controller
    {
        private static Controller _instance;

        private Controller()
        {

        }


        public static Controller GetInstance()
        {
            if(_instance == null)
                _instance = new Controller();

            return _instance;
        }


        public List<T> Search<T>(string input) where T : IModel
        {

        }

    }
}
