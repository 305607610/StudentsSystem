using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace StuManageSys
{
    class DataBase
    {
        private string SqlConnectionString;    //数据库连接

        /// <summary>
        /// 构造函数
        /// 初始化连接数据库参数
        /// </summary>
        public DataBase()
        {
            SqlConnectionString = "Data Source=localhost;Initial Catalog=StuSys;User ID=sa;pwd=320825;Connection Lifetime=0;max pool size=200";
        }

        /// <summary>
        /// 构造函数
        /// 初始化连接数据库参数
        /// </summary>
        /// <param name="ConSqlServer">连接对象</param>
        public DataBase(string ConSqlServer)
        {
            SqlConnectionString = ConSqlServer;
        }

        /// <summary>
        /// 打开数据库连接
        /// </summary>
        /// <param name="cn">连接</param>
        public void Open(SqlConnection cn)
        {
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }
        }

        /// <summary>
        /// 关闭数据库连接
        /// </summary>
        /// <param name="cn">连接</param>
        public void Close(SqlConnection cn)
        {
            if (cn != null)
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                cn.Dispose();
            }
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="strSql">SQL语句</param>
        /// <returns>是否存在</returns>
        public bool ChaXun(string strSql)
        {
            SqlConnection cn = new SqlConnection(SqlConnectionString);
            SqlCommand cmd = new SqlCommand();
            try
            {
                Open(cn);
                cmd = new SqlCommand(strSql, cn);
                return cmd.ExecuteReader().Read();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                cmd.Dispose();
                Close(cn);
            }
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="strSql">SQL语句</param>
        /// <returns>第一行第一列结果</returns>
        public string ChaXun2(string strSql)
        {
            SqlConnection cn = new SqlConnection(SqlConnectionString);
            SqlCommand cmd = new SqlCommand();
            try
            {
                Open(cn);
                cmd = new SqlCommand(strSql, cn);
                return cmd.ExecuteScalar().ToString().Trim();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                cmd.Dispose();
                Close(cn);
            }
        }

        /// <summary>
        /// 查询（SqlDataReader）
        /// </summary>
        /// <param name="strSql">SQL语句</param>
        /// <returns>查询结果</returns>
        public SqlDataReader GetDR(string strSql)
        {
            SqlConnection cn = new SqlConnection(SqlConnectionString);
            SqlCommand cmd = new SqlCommand();
            try
            {
                Open(cn);
                cmd = new SqlCommand(strSql, cn);
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                cmd.Dispose();
            }
        }

        /// <summary>
        /// 查询（DataSet）
        /// </summary>
        /// <param name="strSql">SQL语句</param>
        /// <returns>查询结果</returns>
        public DataSet GetDS(string strSql)
        {
            SqlConnection cn = new SqlConnection(SqlConnectionString);
            SqlDataAdapter sda = new SqlDataAdapter();
            try
            {
                Open(cn);
                sda = new SqlDataAdapter(strSql, cn);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                return ds;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                sda.Dispose();
                Close(cn);
            }
        }

        /// <summary>
        /// 查询（DataSet）
        /// </summary>
        /// <param name="strSql">SQL语句</param>
        /// <param name="tableName">指定DataSet["tableName"]表</param>
        /// <returns>查询结果</returns>
        public DataSet GetDS(string strSql, string tableName)
        {
            SqlConnection cn = new SqlConnection(SqlConnectionString);
            SqlDataAdapter sda = new SqlDataAdapter();
            try
            {
                Open(cn);
                sda = new SqlDataAdapter(strSql, cn);
                DataSet ds = new DataSet();
                sda.Fill(ds, tableName);
                return ds;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                sda.Dispose();
                Close(cn);
            }
        }

        /// <summary>
        /// 查询（DataTable）
        /// </summary>
        /// <param name="strSql">SQL语句</param>
        /// <returns>查询结果</returns>
        public DataTable GetDT(string strSql)
        {
            return GetDS(strSql).Tables[0];
        }

        /// <summary>
        /// 查询（DataView）
        /// </summary>
        /// <param name="strSql">SQL语句</param>
        /// <returns>查询结果</returns>
        public DataView GetDV(string strSql)
        {
            return GetDS(strSql).Tables[0].DefaultView;
        }

        /// <summary>
        /// 增删改，无图片
        /// </summary>
        /// <param name="strSql">SQL语句</param>
        /// <returns>影响的行数</returns>
        public int RunSql(string strSql)
        {
            SqlConnection cn = new SqlConnection(SqlConnectionString);
            SqlCommand cmd = new SqlCommand();
            try
            {
                Open(cn);
                cmd = new SqlCommand(strSql, cn);
                return cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                cmd.Dispose();
                Close(cn);
            }
        }

        /// <summary>
        /// 增改，有图片
        /// </summary>
        /// <param name="strSql">SQL语句</param>
        /// <param name="picbyte">图片的二进制数据</param>
        /// <returns>影响的行数</returns>
        public int RunSql(string strSql, byte[] picbyte)
        {
            SqlConnection cn = new SqlConnection(SqlConnectionString);
            SqlCommand cmd = new SqlCommand();
            try
            {
                Open(cn);
                cmd = new SqlCommand(strSql, cn);
                cmd.Parameters.Add("@Image", SqlDbType.Image);
                cmd.Parameters["@Image"].Value = picbyte;
                return cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                cmd.Dispose();
                Close(cn);
            }
        }
    }
}
