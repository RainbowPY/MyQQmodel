using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQQDAL
{
    public class DBSqlHelp
    {
        //创建一个连接对象（默认null）
        private SqlConnection con = null;

        /// <summary>
        /// 打开数据库
        /// </summary>
        private void OpenSqlConnection()
        {


            //第一步获取连接数据库的访问地址（ip地址、数据课名称、账号、密码）
            string connactionstring = "Data Source=127.0.0.1;Initial Catalog=QQsql;User ID=sa;Password=123456";

            //第二步打开数据库
            con = new SqlConnection(connactionstring);
            if (con.State == ConnectionState.Closed) {
                con.Open();//打开数据库
            }
            else if (con.State == ConnectionState.Broken)
            {

                con.Close();//先关闭
                con.Open();
            }

            // return con;//返回连接对象

        }


        
        /// <summary>
        /// 关闭数据库连接对象
        /// </summary>
        private void CloseSqlConnection()
        {
            try//
            {
                if (con != null) {
                    if (con.State == ConnectionState.Open || con.State == ConnectionState.Broken)
                    {
                        con.Open();//打开数据库
                    }

                }
            } catch (Exception)
            {
                Console.WriteLine("数据库链接关闭失败，非常严重......");
            }
            finally//
            {
                con.Close();//关闭数据库
            }

        }

 
        /// <summary>
        /// 处理数据库的各种 插入  删除  修改操作
        /// </summary>
        /// <param name="sql">要执行的TSQL语句命令</param>
        /// <returns>true执行成功  false 执行失败</returns>

        public bool SQL_ExecuteNonQuery(string sql)
        {
            try
            {
                //第一步打开数据库
                OpenSqlConnection();
                //第二步创建执行SQL语句对象
                SqlCommand cmd = new SqlCommand(sql, con);
                //第三步执行语句 并返回影响的行数  影响0执行失败  影响1执行成功
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    return true;
                }


            }
            catch (Exception)
            {
                Console.WriteLine("执行TSQL命令出错，请联系管理员！123465789");

            }
            finally
            {
                CloseSqlConnection(); //关闭数据库
            }
            return false;

        }


            //处理数据库的 查看操作
    
        /// <summary>
        /// 获取数据库的各种查询操作
        /// </summary>
        /// <param name="sql">要查询的TSQL命令 一般全部为select查询</param>
        /// <returns>返回结果数据集DataSet（别名 tables）</returns>
        public DataSet SQL_GetData(string sql)
        {
            try
            {
                //第一步打开数据库
                OpenSqlConnection();
                //第二步创建执行SQL语句对象
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                //创建一个数据集
                DataSet ds = new DataSet();
                //第三步执行语句 把执行后返回的数据  存放到数据集ds中 并起名为tables
                adapter.Fill(ds, "tables");
                return ds;

            }
            catch (Exception)
            {
                Console.WriteLine("执行SQL命令出错，请联系管理员！123456789");

            }
            finally
            {
                CloseSqlConnection(); //关闭数据库
            }
            return null;
        }
    }

    
}
