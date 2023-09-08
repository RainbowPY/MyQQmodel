using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQQModel
{
    public class Friend
    {
        private int _qq好友编号;
        private string _qq我的QQ;
        private string _qq好友QQ;
        private int _qq所属组_编号;
        private int _qq添加状态_编号;
        private DateTime _qq申请添加时间;

        //额外列
        private string _QQ昵称;
        private string _QQ头像;
      
        private string _QQ个性签名;

        public int Qq好友编号 { get => _qq好友编号; set => _qq好友编号 = value; }
        public string Qq我的QQ { get => _qq我的QQ; set => _qq我的QQ = value; }
        public string Qq好友QQ { get => _qq好友QQ; set => _qq好友QQ = value; }
        public int Qq所属组_编号 { get => _qq所属组_编号; set => _qq所属组_编号 = value; }
        public int Qq添加状态_编号 { get => _qq添加状态_编号; set => _qq添加状态_编号 = value; }
        public DateTime Qq申请添加时间 { get => _qq申请添加时间; set => _qq申请添加时间 = value; }
        public string QQ昵称 { get => _QQ昵称; set => _QQ昵称 = value; }
        public string QQ头像 { get => _QQ头像; set => _QQ头像 = value; }
        public string QQ个性签名 { get => _QQ个性签名; set => _QQ个性签名 = value; }
    }
}
