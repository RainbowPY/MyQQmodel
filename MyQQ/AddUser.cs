using MyQQBLL;
using MyQQModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyQQ

{
    public partial class AddUser : Form
    {

        //实例化一个业务逻辑类 BLL
        QQUserBLL bll = new QQUserBLL();
        //实例化省逻辑层
        ShengBLL shengbll = new ShengBLL();

        //实例化 shibll
        ShiBLL shibll = new ShiBLL();


        public AddUser()
        {
            InitializeComponent();
        }




        /// <summary>
        /// 注册QQ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void btn注册_Click(object sender, EventArgs e)
        {

            #region  封装数据到实体类中
            //随机生成QQ号
            Random rd = new Random();//创建一个随机数对象 
            //接收用户输入的所有基本信息
            QQUserEntity user = new QQUserEntity();
            user.Qq号 = rd.Next(1000000, 9999999).ToString(); //自动生成QQ号 （1000000-9999999之间）
            user.Qq密码 = this.txt密码1.Text.Trim();
            //判断两次密码是否一致
            if (txt密码2.Text.Trim() == user.Qq密码)
            {
                user.Qq姓名 = txt姓名.Text.Trim();
                user.Qq昵称 = txt昵称.Text.Trim();
                user.Qq性别 = rd男.Checked == true ? "男" : "女";
                user.Qq生日 = DateTime.Parse(dt生日.Text.Trim());
                user.Qq手机号 = txt手机号.Text.Trim();
                user.Qq星座 = cbx星座.Text.Trim();
                user.Qq省_编号 = cbx省.SelectedValue.ToString();
                user.Qq市_编号 = cbx市.SelectedValue.ToString();
                user.Qq区_编号 = cbx区.SelectedValue.ToString();
                user.Qq详细地址 = txt详细地址.Text.Trim();
            }
            else
            {
                MessageBox.Show("两次密码不一致，请重新输入!");
                this.txt密码1.Focus();//把鼠标的光标直接定位到 密码框上 
            }
           #endregion

            //调用QQUserBLL类中的AddQQUser方法，把数据 添加到数据库中
            bool bl = bll.AddQQUser(user);
            if (bl == true)
            {
                MessageBox.Show("注册成功！你的QQ号为:" + user.Qq号 + " 请牢记！", "恭喜你注册成功");
                this.Close();
            }
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
           
        }



        /// <summary>
        /// 根据省编号 加载城市
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbx省_SelectedIndexChanged(object sender, EventArgs e)
        {
            //获取省编号
            string sid = cbx省.SelectedValue.ToString();
            //根据省编号 获取所对应的城市
            DataSet ds = shengbll.GetCityList(sid);
            //把数据绑定到cbx市下拉列表框中
            
            cbx市.DataSource = ds.Tables[0];//数据源的绑定可以来自于 DataSet数据集 也可以来源于List<泛型集合>


        }
        /// <summary>
        /// 根据城市 查询区
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbx市_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbx区.DataSource = shibll.GetQuByShiId(this.cbx市.SelectedValue.ToString()).Tables[0];
        }

        private void AddUser_Load_1(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“qQsqlDataSet2.省”中。您可以根据需要移动或移除它。
            this.省TableAdapter.Fill(this.qQsqlDataSet2.省);
            // TODO: 这行代码将数据加载到表“qQsqlDataSet1.省”中。您可以根据需要移动或移除它。
            //this.省TableAdapter.Fill(this.qQsqlDataSet1.省);


           // this.省TableAdapter1.Fill(this.qQsqlDataSet.省);
            // TODO: 这行代码将数据加载到表“myqqdbDataSet.省”中。您可以根据需要移动或移除它。
          
            

        }
    }
}
