using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQQModel
{
    public class SendMessageEntity
    {
        private int _qq聊天记录编号;
        private string _qq我的QQ;
        private string _qq好友QQ;
        private string _qq聊天内容;
        private string _qq查看状态;
        private DateTime _qq聊天时间;

        public int Qq聊天记录编号 { get => _qq聊天记录编号; set => _qq聊天记录编号 = value; }
        public string Qq我的QQ { get => _qq我的QQ; set => _qq我的QQ = value; }
        public string Qq好友QQ { get => _qq好友QQ; set => _qq好友QQ = value; }
        public string Qq聊天内容 { get => _qq聊天内容; set => _qq聊天内容 = value; }
        public string Qq查看状态 { get => _qq查看状态; set => _qq查看状态 = value; }
        public DateTime Qq聊天时间 { get => _qq聊天时间; set => _qq聊天时间 = value; }
    }
}
