using MyQQBLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyQQ
{
    public partial class Message : Form
    {


        //定义一个QQ号变量 用来存储自己的登录QQ信息
        private string _qq = string.Empty;

        //申请加自己为好友的QQ
        private string _fqq = string.Empty;

        //申请添加好友记录的ID编号（其实就是数据库中的“好友编号”这一列）
        private int _id;
        //昵称
        private string _nicheng = string.Empty;

        //实例化业务逻辑层对象，方便给下面芳芳调用
        /// <summary>
        /// 页面构造器
        /// </summary>
        /// <param name="qq">自己的QQ号</param>
        /// <param name="id">申请添加好友编号</param>
        /// <param name="nicheng">昵称</param>
        public Message(string qq, int id, string nicheng, string fqq)
        {
            InitializeComponent();
            //把参数传过来的值 赋值给本地变量 提供后期使用
            _qq = qq;//自己的QQ号
            _id = id;//申请好友添加记录编号 主要用来更新这条记录
            _nicheng = nicheng;//申请人的昵称
            _fqq = fqq;//申请加自己为好友的QQ
        }

        QQUserBLL bll = new QQUserBLL();
        public Message()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // this.Close();//最简单的关闭窗体

            this.timer1.Enabled = false;
            for (int i = 0; i < this.Height; i++)
            {
                //弹出框向下移动消失
                Point p = new Point(this.Location.X, this.Location.Y + i);
                this.PointToClient(p);
                this.Location = p;
                System.Threading.Thread.Sleep(10);//暂停程序0.01秒 
            }
            this.Close();//关闭窗体
            this.Dispose();//释放所有资源
        }


        //拒绝
        private void button2_Click(object sender, EventArgs e)
        {
            bll.UpdateQQFriendState(_id, 4);//直接更新第一次申请记录 状态为4  拒绝成为好友
            MessageBox.Show("已拒绝对方添加好友请求!");
            this.Close();
        }



        //同意添加
        private void button1_Click(object sender, EventArgs e)
        {
            //再重新王数据库表中添加一条  他是我的好友
            bll.AddFriend(_qq, _fqq, 3);//添加一条记录
            //同时更新第一次申请加为好友的那条记录 状态编号也要更改为3
            bll.UpdateQQFriendState(_id, 3);
            MessageBox.Show("已成功添加为好友，你们可以正常聊天了！");
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bll.UpdateQQFriendState(_id, 5);//直接更新第一次申请记录 状态为4  拒绝成为好友
            MessageBox.Show("已加入黑名单，此人无法再次添加你为好友!");
            this.Close();
        }

        private void Message_Load(object sender, EventArgs e)
        {
            this.lab昵称.Text = _nicheng;
        }
    }
}
