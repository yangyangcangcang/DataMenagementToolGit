using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDTY.BasicDataManagement.Model;
using System.Data.OleDb;
using System.Configuration;
using CDTY.BasicDataManagement.Common;

namespace CDTY.BasicDataManagement.DAL
{
    public class AccessSqlHelper : IBaseDAL
    {
        private static readonly string connStr = ConfigurationManager.ConnectionStrings["accessSql"].ConnectionString;

        public void Delete<T>(T t) where T : BaseModel
        {

        }

        public T Find<T>(int id) where T : BaseModel
        {
            Type type = typeof(T);
            string strColumn = string.Join(",", type.GetProperties().Select(p => $"[{p.GetColumnName()}]"));
            string sql = $"SELECT {strColumn} FROM [{type.Name}] WHERE Id={id}";
            T t = (T)Activator.CreateInstance(type);
            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                conn.Open();

                OleDbDataReader reader = cmd.ExecuteReader();

                t = this.ReaderToList<T>(reader).FirstOrDefault();//返回集合中第一个  没有的话为null
                #region 注释
                //if (reader.Read())//表示有数据
                //{
                //    foreach (var prop in type.GetProperties())
                //    {
                //        prop.SetValue(t, reader[prop.Name] is DBNull?null: reader[prop.Name]);
                //    }
                //} 
                #endregion
            }
            return t;
        }

        public IList<T> FindAll<T>() where T : BaseModel
        {
            Type type = typeof(T);
            string strColumn = string.Join(",", type.GetProperties().Select(p => $"[{p.GetColumnName()}]"));
            string sql = $"SELECT {strColumn} FROM [{type.Name}]";
            IList<T> list = new List<T>();
            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                conn.Open();
                OleDbDataReader reader = cmd.ExecuteReader();
                list = this.ReaderToList<T>(reader);
                #region 注释
                //while (reader.Read())//表示有数据
                //{
                //    T t = (T)Activator.CreateInstance(type);
                //    foreach (var prop in type.GetProperties())
                //    {
                //        prop.SetValue(t, reader[prop.Name] is DBNull ? null : reader[prop.Name]);
                //    }
                //    list.Add(t);
                //}  
                #endregion
            }
            return list;
        }

        public void Insert<T>(T t) where T : BaseModel
        {
            Type type = typeof(T);
            //insert into SysUserInfo(Name, Age) values(N'张三', 12)
            try
            {
                var propArray = type.GetProperties().Where(p => !"TableName".Equals(p.Name));
                string strColumn = string.Join(",", propArray.Select(p => $"[{ p.GetColumnName()}]"));
                string strColumnValues = string.Join(",", propArray.Select(p => $"@{ p.GetColumnName()}"));
                var parameters = propArray.Select(p => new OleDbParameter($"@{p.GetColumnName()}", p.GetValue(t))).ToArray();
                string sql = $"insert into {t.TableName}({strColumn}) values({strColumnValues})";
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {
                    OleDbCommand cmd = new OleDbCommand(sql, conn);

                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    conn.Open();
                    int nResult = cmd.ExecuteNonQuery();
                    if (nResult == 0)
                    {
                        throw new Exception("Update数据不存在");
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update<T>(T t) where T : BaseModel
        {
            Type type = typeof(T);
            var propArray = type.GetProperties().Where(p => !p.Name.Equals("ID"));
            string strColumn = string.Join(",", propArray.Select(p => $"[{p.GetColumnName()}]=@{p.GetColumnName()}"));
            //必须参数化 
            var parameters = propArray.Select(p => new OleDbParameter($"@{p.GetColumnName()}", p.GetValue(t))).ToArray();
            string sql = $"UPDATE {type.Name} SET {strColumn} WHERE number = {t.number}";
            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                cmd.Parameters.AddRange(parameters);
                conn.Open();
                int nResult = cmd.ExecuteNonQuery();
                if (nResult == 0)
                {
                    throw new Exception("Update数据不存在");
                }
            }
        }

        private IList<T> ReaderToList<T>(OleDbDataReader reader) where T : BaseModel
        {
            Type type = typeof(T);
            List<T> list = new List<T>();
            while (reader.Read())//表示有数据
            {
                T t = (T)Activator.CreateInstance(type);
                foreach (var prop in type.GetProperties())
                {
                    prop.SetValue(t, reader[prop.GetColumnName()] is DBNull ? null : reader[prop.GetColumnName()]);
                }
                list.Add(t);
            }
            return list;
        }

    }
}
