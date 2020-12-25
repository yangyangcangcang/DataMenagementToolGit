using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CDTY.BasicDataManagement.Common
{
    public static class AttributeHelper
    {
        public static string GetColumnName(this PropertyInfo propertyInfo)
        {

            if (propertyInfo.IsDefined(typeof(ColumnAttribute), true))
            {
                ColumnAttribute columnAttribute = (ColumnAttribute)propertyInfo.GetCustomAttribute(typeof(ColumnAttribute), true);
                return columnAttribute.GetColumnName();
            }
            return propertyInfo.Name;
        }
    }
}
