using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace back_end
{
    /// <summary>
    /// Provides a Catalog specific entrypoint to SingletonFactory
    /// </summary>
    /// <typeparam name="T">Specifies the type of the desired Catalog</typeparam>
    class CatalogFactory<T> where T : IModel
    {
        /// <summary>
        /// Gets the Catalog specific instance of SingletonFactory,
        /// which then tells it to return a Catalog of the specifed type
        /// </summary>
        /// <returns type="Catalog<T>">A singleton Catalog of the specified type</returns>
        public static Catalog<T> Get()
        {
            // return an instance of SingletonFactory, then return the specified singleton
            return SingletonFactory<Catalog<T>>.Instance.Singleton;
        }
    }
}

