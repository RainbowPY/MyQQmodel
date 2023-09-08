using MyQQDAL;
using MyQQModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQQBLL
{
    public class ShengBLL
    {
        ShengDAL dal = new ShengDAL();
        /// <summary>
        /// 根据省编号
        /// </summary>
        /// <param name="sid"></param>
            /// <returns></returns>
        public DataSet GetCityList(string sid)
        {
             return dal.GetCityList(sid);
        }
        public List<ShiEntity> GetCityListEntity(string sid)
        {
            DataSet ds = dal.GetCityList(sid);
            List<ShiEntity> list = new List<ShiEntity>();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                ShiEntity shi = new ShiEntity();    
                shi.Qq市编号 = ds.Tables[0].Rows[i]["市_编号"].ToString();
                shi.Qq市名称 = ds.Tables[0].Rows[i]["市名称"].ToString();
                shi.Qq所属省_编号 = ds.Tables[0].Rows[i]["省_编号"].ToString();
                list.Add(shi);//把ds数据集中的所有数据 封装到实体类中 再加入集合

            }
            return list;
        }
        
    }
}
