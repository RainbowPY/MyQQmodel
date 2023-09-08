using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQQDAL
{
    public class ShiDAL:DBSqlHelp
        
    {
        ShengDAL dal = new ShengDAL();
        public DataSet GetQuByShiId(string cid)
        {
            string sql = "select * from 区 where  市_编号='" + cid + "'";
            return SQL_GetData(sql);
        }

    }
}
