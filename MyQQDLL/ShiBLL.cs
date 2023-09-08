using MyQQDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyQQBLL
{
    public class ShiBLL
    {
        ShiDAL dal = new ShiDAL();
        public DataSet GetQuByShiId(string cid)
        {
            return dal.GetQuByShiId(cid);
        }
    }
}
