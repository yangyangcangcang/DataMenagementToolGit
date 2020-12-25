using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDTY.BasicDataManagement.DAL
{
    /// <summary>
    /// Access 数据库  读写操作
    /// </summary>
    public  class SqlAccessHelper
    {
        /// <summary>
        /// 连接字符串
        /// </summary>
        private static readonly string connStr = ConfigurationManager.ConnectionStrings["accessSql"].ConnectionString;
        //Provider=Microsoft.ACE.OLEDB.12.0;Data Source = C:\Users\msz\Desktop\JHCS.mdb
        #region 执行 增删改
        /// <summary>
        /// 执行 增删改  
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="pms"></param>
        /// <returns></returns>
        public static int ExcuteNonQuery(string sql, params OleDbParameter[] pms)
        {
            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
               
                using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                {
                    if (pms != null)
                    {
                        cmd.Parameters.AddRange(pms);
                    }
                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region 执行查询，返回单个值
        /// <summary>
        /// 执行查询，返回单个值
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="pms"></param>
        /// <returns></returns>
        public static object ExecuteScalar(string sql, params OleDbParameter[] pms)
        {
            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                {
                    if (pms != null)
                    {
                        cmd.Parameters.AddRange(pms);
                    }
                    conn.Open();
                    return cmd.ExecuteScalar();
                }
            }
        }
        #endregion

        #region 返回SqlDataReader
        /// <summary>
        /// 返回SqlDataReader 多行
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="pms"></param>
        /// <returns></returns>
        public static OleDbDataReader ExecuteReader(string sql, params OleDbParameter[] pms)
        {
            OleDbConnection conn = new OleDbConnection(connStr);
            using (OleDbCommand cmd = new OleDbCommand(sql, conn))
            {
                if (pms != null)
                {
                    cmd.Parameters.AddRange(pms);
                }
                try
                {
                    conn.Open();
                    //System.Data.CommandBehavior.CloseConnection 将来使用SqlDataReader后 关闭reader的同时，在SqlDataReader内部会将SqlConnection对象也关闭掉
                    return cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                    //return cmd.ExecuteScalar();
                }
                catch //发生异常时，将连接关闭  并抛出异常
                {
                    conn.Close();
                    conn.Dispose();
                  
                    throw;
                }
            }
        }
        #endregion

        public static bool IsTableEmpty(string tableName)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {

                    conn.Open();
                    DataTable tables = conn.GetSchema("Tables");
                    foreach (DataRow item in tables.Rows)
                    {
                        if (tableName.Equals(item[2].ToString()))
                        {
                            return true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            return false;
        }


    }
}
