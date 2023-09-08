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

namespace MyQQ
{
    public partial class userxinxi : Form
    {
        public userxinxi(string qq)
        {
            InitializeComponent();
            labQQ.Text = qq;
        }

       


        // 关闭窗口
        private void button1_Click(object sender, EventArgs e)
        {
            Close();    
        }

        private void userxinxi_Load(object sender, EventArgs e)
        {
            //实例化QQ用户BLL业务逻辑对象
            QQUserBLL bll = new QQUserBLL();
            //通过BLL对象调用GetQQUserInfo方法来执行查询
            QQUserEntity user = bll.GetQQUserInfo(this.labQQ.Text);//根据QQ号查询

            lab个性签名.Text = user.Qq个性签名;
            lab姓名.Text = user.Qq姓名;
            lab市.Text = user.Qq市_编号;
            lab性别.Text = user.Qq性别;
            lab星座.Text = user.Qq星座;
            lab昵称.Text = user.Qq昵称;
            lab生日.Text = user.Qq生日.ToString();
            lab省.Text = user.Qq省_编号;
            lab地址.Text = user.Qq详细地址;
            lab区.Text= user.Qq区_编号;
           // lab头像.
        }

        
    }
}
