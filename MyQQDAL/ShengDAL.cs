using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQQDAL
{
    public class ShengDAL:DBSqlHelp
    {


        /// <summary>
        /// 根据省编号 查询对应所在城市
        /// </summary>
        /// <param name="sid"></param>
        /// <returns></returns>
        public DataSet GetCityList(string sid)
        {
            //创建查询
            string sql = "select * from 市 where 省_编号='" + sid + "'";
            return SQL_GetData(sql);
           

        }
    }
}
