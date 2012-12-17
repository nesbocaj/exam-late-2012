using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datalayer
{
    abstract class DatabaseConnection<T>
    {
        private static T _instance;

        T Instance
        {
            get
            {
                if (_instance == null)
                    _instance = (T)Activator.CreateInstance(typeof(T));
                return _instance;
            }
        }
    }
}
