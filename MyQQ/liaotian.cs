using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyQQModel;
using MyQQBLL;
using MyQQDLL;

namespace MyQQ
{
    public partial class liaotian : Form
    {
        private string qq = string.Empty;//好友登录qq 
        private string nicheng = string.Empty;//好友昵称
        private string gexingqianming = string.Empty;//好友个性签名

        private string myqq = string.Empty;//自己QQ号(主界面传过来值)
        private string mynicheng = string.Empty;//自己昵称
        private string mygexingqianming = string.Empty;//自己个性签名
        public liaotian()
        {
            InitializeComponent();
        }

        public string Qq { get => qq; set => qq = value; }
        public string Nicheng { get => nicheng; set => nicheng = value; }
        public string Gexingqianming { get => gexingqianming; set => gexingqianming = value; }
        public string Myqq { get => myqq; set => myqq = value; }
        public string Mynicheng { get => mynicheng; set => mynicheng = value; }
        public string Mygexingqianming { get => mygexingqianming; set => mygexingqianming = value; }

        private void liaotian_Load(object sender, EventArgs e)
        {
            lab个性签名.Text = gexingqianming;
            lab昵称.Text = nicheng;
        }



        //发送消息
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {



                //创建一个变量用来存放聊天内容
                string txt = mynicheng + " " + DateTime.Now.ToString() + "\n" + this.richTextBox2.Text + "\n";

                //把消息添加到数据表中
                SendMessageBLL bll = new SendMessageBLL();
                SendMessageEntity s = new SendMessageEntity();
                s.Qq聊天内容 = txt;
                s.Qq我的QQ = myqq;//自己的QQ
                s.Qq好友QQ = qq;//好友QQ
                if (bll.AddMessage(s))
                {
                    this.richTextBox1.AppendText(txt);//把聊天内容追加到显示框中
                    this.richTextBox2.Text = "";//清空发送文本框 
                }
                else
                {
                    MessageBox.Show("发送失败，请检查您的网络是否稳定！");
                }
            }
            catch (Exception ex)
            {
                //记录错误日志
                Console.WriteLine("发送消息错误：" + ex.ToString());
            }

        }

        private void richTextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                button1_Click(sender, e);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
