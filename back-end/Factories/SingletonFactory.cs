using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace back_end
{
    /// <summary>
    /// A factory-like pattern for creation of type-specific singletons
    /// </summary>
    /// <typeparam name="T">Specifies the type of the desired singleton</typeparam>
    class SingletonFactory<T>
    {
        private static SingletonFactory<T> _instance;
        private Hashtable _singletons = null;

        /// <summary>
        /// Private constructor since it's a singleton
        /// </summary>
        private SingletonFactory()
        {
            // instantiate _singletons as a new Hashtable
            _singletons = new Hashtable();
        }

        /// <summary>
        /// Return the instance of SingletonFactory<T>
        /// </summary>
        /// <returns type="SingletonFactory<T>"></returns>
        public static SingletonFactory<T> Instance
        {
            get
            {
                // instantiate _instance if it doesn't exist
                if (_instance == null)
                    _instance = new SingletonFactory<T>();

                return _instance;
            }
        }

        /// <summary>
        /// Checks if a singleton of the given type exists in the Hashtable,
        /// if it doesn't create a new instance of the given type
        /// and add it to the Hashtable.
        /// Finally return the singleton
        /// </summary>
        /// <returns type="T">A singleton</returns>
        public T Singleton
        {
            get
            {
                Type type = typeof(T);

                // add a new instance of the singleton to _singletons if it doesn't exist
                if (!_singletons.Contains(type.ToString()))
                    _singletons.Add(type.ToString(), Activator.CreateInstance(type));

                return (T)_singletons[type.ToString()];
            }
        }
    }
}

