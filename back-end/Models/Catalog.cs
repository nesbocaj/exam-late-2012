﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace back_end
{
    /// <summary>
    /// A catalog for IModel type objects
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class Catalog<T> where T : IModel
    {
        private Dictionary<int, T> _dictionary;

        /// <summary>
        /// Constructor
        /// </summary>
        public Catalog()
        {
            _dictionary = new Dictionary<int, T>();
        }

        /// <summary>
        /// Provides array-like access to the catalog items
        /// </summary>
        public T this[int i]
        {
            get { return _dictionary[i]; }
            set { _dictionary[i] = value; }
        }

        /// <summary>
        /// Add a new item to the Catalog
        /// </summary>
        /// <param name="tmp" type="T"></param>
        public void Add(T tmp)
        {
            // get the id of the current object tmp
            int id = (int)typeof(T).GetProperty("ID").GetValue(tmp, null);
            _dictionary.Add(id, tmp);
        }

        /// <summary>
        /// Remove the Catalog item with the specified id
        /// </summary>
        /// <param name="id" type="int"></param>
        public void Remove(int id)
        {
            _dictionary.Remove(id);

            // force invoking of destructors, useful for database managment
            GC.Collect();
        }

        public T Get(string input)
        {
            int num;
            T output = default(T);
            if (Int32.TryParse(input, out num))
            {
                try
                {
                    //typeof(T).GetProperty("")
                }
                catch (Exception all)
                {

                }
                return output;
            }
            else
            {
                return output;
            }
        }

    }
}
