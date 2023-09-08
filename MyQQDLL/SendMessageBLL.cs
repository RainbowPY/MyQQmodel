using MyQQDAL;
using MyQQModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQQDLL
{
    public class SendMessageBLL
    {
        SendMessageDAL dal = new SendMessageDAL();



        /// <summary>
        /// 添加消息
        /// </summary>
        /// <param name="ms">聊天内容</param>
        /// <returns></returns>
        public bool AddMessage(SendMessageEntity ms)
        {
            return dal.AddMessage(ms);

        }


        /// <summary>
        /// 读取聊天消息
        /// </summary>
        /// <param name="qq">自己的QQ</param>
        /// <param name="fqq">好友的QQ</param>
        /// <returns>DataTable 聊天记录</returns>
        public List<SendMessageEntity> GetMessagesList(string qq, string fqq)
        {
            DataTable dt = dal.GetMessagesList(qq, fqq);

            //非空验证
            if (dt != null)
            {
                //循环封装数据到List集合中
                List<SendMessageEntity> list = new List<SendMessageEntity>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    SendMessageEntity s = new SendMessageEntity();
                    s.Qq好友QQ = dt.Rows[i]["好友QQ"].ToString();
                    s.Qq我的QQ = dt.Rows[i]["我的QQ"].ToString();
                    s.Qq聊天记录编号 = (int)dt.Rows[i]["聊天记录编号"];
                    s.Qq聊天内容 = dt.Rows[i]["聊天内容"].ToString();
                    s.Qq查看状态 = dt.Rows[i]["查看状态"].ToString();
                    s.Qq聊天时间 = (DateTime)dt.Rows[i]["聊天时间"];
                    list.Add(s);//装入集合中
                }
                return list;
            }

            return null;//如果没有查询到数据 就返回NULL 空 
        }
    }
}
