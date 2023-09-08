using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyQQ
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 登录账号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string uid = this.txtuid.Text.Trim();//获取账号
            string pwd = this.txtpwd.Text.Trim();//获取密码

            if (uid !="" && uid.Length >0)
            {

            
                //验证账号和密码长度
                //判断密码长度是否为6-15位之间
                if (pwd.Length >=6 && pwd.Length <=15)
                {
                    //验证账号和密码是否正确（去数据库中查询）
                    // MessageBox.Show("登录成功!");
                    try
                    {

                   
                        //第一步获取连接数据库的访问地址（ip地址、数据课名称、账号、密码）
                        string connactionstring = "Data Source=127.0.0.1;Initial Catalog=QQsql;User ID=sa;Password=123456";

                        //第二步打开数据库
                        SqlConnection connection = new SqlConnection(connactionstring);
                        connection.Open();//打开数据库
                        //第三步 创建执行对象
                        string sql = "select * from 用户 where 账号=" + uid + "and 密码=" + pwd + "";
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, connection);

                        //
                        DataSet ds = new DataSet();
                        dataAdapter.Fill(ds,"table");
                        //
                        if (ds != null && ds.Tables[0].Rows.Count > 0)
                        {
                           
                            //登录成功
                            this.Hide();//隐藏自身
                            //弹出主界面
                            Main m = new Main(uid);
                            m.Show();
                           // new Main().Show();//后期不好调用

                        }
                        else
                        {
                            MessageBox.Show("账号或密码错误", "登陆失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }




                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("数据库连接失败！" + ex.ToString());
                        //Console.WriteLine("数据库打开失败" + e.ToString());
                    }          
                }
                else
                {
                    //标准弹出框按钮参数   MessageBox.Show（“提示按钮”，“标题栏文字”，“要显示的按钮”，“消息”）
                    MessageBox.Show("密码长度错误，请输入正确密码6-15位之间","密码错误",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("QQ账号不为空", "账号错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void txtuid_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtuid.Text == "QQ号/手机/邮箱")
            this.txtuid.Text = "";
        }

        private void txtpwd_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtuid.Text == "")
            {
                this.txtuid.Text = "QQ号/手机/邮箱";
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new AddUser().ShowDialog();
        }

       
    }
}
