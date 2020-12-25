using System;

namespace CDTY.BasicDataManagement.Common
{

    [AttributeUsage(AttributeTargets.Property)]//定义特性只修饰Property
    public class ColumnAttribute:Attribute
    {
        private string _Name = string.Empty;

        public string GetColumnName()
        {
            return this._Name;
        }

        public ColumnAttribute(string name)
        {
            this._Name = name;
        }

    }
}