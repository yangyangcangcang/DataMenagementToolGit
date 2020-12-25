using CDTY.BasicDataManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDTY.BasicDataManagement.DAL
{
    public  class LBaseDB
    {
        #region 创建D工作表
        public static bool CreateBaseLTable(string TableName)
        {
            try
            {
                if (string.IsNullOrEmpty(TableName))
                {
                    return false;
                }
                if (SqlAccessHelper.IsTableEmpty($"{TableName}L"))
                {
                    return false;
                }
                string sql = $"Create table {TableName}L([number] integer identity(1,1) primary key, [stationname] varchar(32),jingdu integer,weidu integer,heig integer)";
                int nResult = SqlAccessHelper.ExcuteNonQuery(sql);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        #endregion

        //添加数据
        public static bool Insert(string TableName, BaseL baseL)
        {
            //public int number { get; set; }
            //public string stationname { get; set; }
            //public int jingdu { get; set; }
            //public int weidu { get; set; }
            //public int heig { get; set; }
            Type type = typeof(BaseL);
            string str = string.Join(",", type.GetProperties().Where(p => p.Name != "number"));
            string sql = $"INSERT INTO {TableName}L([number],[stationname]) values({baseL.number},'{baseL.stationname}')";
            int nResult = SqlAccessHelper.ExcuteNonQuery(sql);
            return nResult > 0;
        }

    }
}
