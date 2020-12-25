using CDTY.BasicDataManagement.Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDTY.BasicDataManagement.DAL
{
    public  class DBaseDB
    {
        #region 创建D工作表
        public static bool CreateBaseDTable(string TableName)
        {
            try
            {
                if (string.IsNullOrEmpty(TableName))
                {
                    return false;
                }
                if(SqlAccessHelper.IsTableEmpty($"{TableName}D"))
                {
                    return false;
                }

                string sql = $"Create table {TableName}D([number] integer identity(1,1) primary key, [suidaoname] varchar(32))";
                int nResult = SqlAccessHelper.ExcuteNonQuery(sql);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        } 
        #endregion

        public static bool Insert(string TableName,BaseD modelD)
        {
            //创建Sql语句
            Type type = typeof(BaseD);
            string str = string.Join(",",type.GetProperties().Where(p=>p.Name != "number"));
            string sql = $"INSERT INTO {TableName}D({str}) values({modelD.suidaoname})";
            int nResult = SqlAccessHelper.ExcuteNonQuery(sql);
            return nResult > 0;
        }

        public static bool Delete(int id,string TabeleName)
        {
            string sql = $"Delete FROM {TabeleName}D where number={id}";
            int nResult = SqlAccessHelper.ExcuteNonQuery(sql);
            return nResult>0;
        }

        #region 查询全部
        public static List<BaseD> FindAll(string TableName)
        {
            List<BaseD> list = new List<BaseD>();
            Type type = typeof(BaseD);
            string str = string.Join(",", type.GetProperties().Select(p=>p.Name));
            string sql = $"SELECT {str} FROM {TableName}D";
            using (OleDbDataReader reader = SqlAccessHelper.ExecuteReader(sql))
            {
                while (reader.Read())
                {
                    var t1 = reader.GetValue(0);
                    //reader.
                }
            }
            return list;
        }
        #endregion


        #region 查询全部
        public static List<BaseD> FindByID(string TableName,int id)
        {
            List<BaseD> list = new List<BaseD>();
            Type type = typeof(BaseD);
            string str = string.Join(",", type.GetProperties().Select(p => p.Name));
            string sql = $"SELECT {str} FROM {TableName}D where number={id}";
            using (OleDbDataReader reader = SqlAccessHelper.ExecuteReader(sql))
            {
                while (reader.Read())
                {
                    var t1 = reader.GetValue(0);
                    //reader.
                }
            }
            return list;
        }
        #endregion


    }
}
