using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyQQModel;

namespace MyQQDAL
{
    public class SendMessageDAL : DBSqlHelp
    {
        public bool AddMessage(SendMessageEntity ms)
        {

            string sql = "insert into 聊天记录(我的QQ,好友QQ,聊天内容) values('" + ms.Qq我的QQ + "','" + ms.Qq好友QQ + "','" + ms.Qq聊天内容 + "')";
            return SQL_ExecuteNonQuery(sql);
        }
        public DataTable GetMessagesList(string qq, string fqq)
        {
            string sql = "select * from 聊天记录 where (我的QQ='"+qq+"' and 好友QQ='"+qq+"') or (我的QQ='"+qq+"' and 好友QQ='"+fqq+"') order by 聊天时间 desc ";
            return SQL_GetData(sql).Tables[0];//返回一张表

        }
    }
}
