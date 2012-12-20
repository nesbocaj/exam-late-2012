using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;

namespace back_end
{
    class FluentFactory<T>
    {
        private T _construction;

        public FluentFactory(T construction)
        {
            _construction = construction;
        }

        /// <summary>
        /// allows the addition of properties to a fabricated object
        /// </summary>
        /// <param name="property" type="Expression<Func<T, object>>">
        /// the property to which the value is assigned 
        /// </param>
        /// <param name="value" type="object">the desired value for the property</param>
        /// <returns>the current Factory</returns>
        public FluentFactory<T> AddPropertyValue(Expression<Func<T, object>> property, object value)
        {
            PropertyInfo propertyInfo = null;

            // if the property is a 
            if (property.Body is MemberExpression)
            {
                propertyInfo = (property.Body as MemberExpression).Member as PropertyInfo;
            }
            else
            {
                propertyInfo = (((UnaryExpression)property.Body).Operand as MemberExpression).Member as PropertyInfo;
            }

            // set the property to the given value
            propertyInfo.SetValue(_construction, value, null);

            return this;
        }

        public T Create()
        {
            return _construction;
        }
    }
}
