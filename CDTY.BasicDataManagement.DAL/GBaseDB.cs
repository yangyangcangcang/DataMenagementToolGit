using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDTY.BasicDataManagement.DAL
{
    public  class GBaseDB
    {
        #region 创建D工作表
        public static bool CreateBaseGTable(string TableName)
        {
            try
            {
                if (string.IsNullOrEmpty(TableName))
                {
                    return false;
                }
                if (SqlAccessHelper.IsTableEmpty($"{TableName}G"))
                {
                    return false;
                }
                string sql = $"Create table {TableName}G([number] integer identity(1,1) primary key, [stationnum] integer,stationname varchar(32),qiaosuibz integer,qiaosuiname varchar(32),polenum varchar(32),kuaju integer,jiegoubz integer,quxianbz integer,gonglibiao varchar(32),gongdianduanname varchar(32),gongdianduanbz integer,linggongquname varchar(32),linggongqubz integer,gongquname varchar(32),gongqubz integer,daogao integer,lachuzhi integer,Sign_Type varchar(32),Sign_Gonglibiao varchar(32),Flage integer,speed integer)";
                int nResult = SqlAccessHelper.ExcuteNonQuery(sql);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        #endregion
    }
}
