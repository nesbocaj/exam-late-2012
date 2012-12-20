using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace back_end
{
    static class ModelFactory<T> where T : IModel
    {
        public static FluentFactory<T> Init()
        {
            T construction = (T)Activator.CreateInstance(typeof(T));
            return new FluentFactory<T>(construction);
        }

        public static T Load()
        {
            return default(T);
        }
    }
}

