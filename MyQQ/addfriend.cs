using MyQQBLL;
using MyQQModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyQQ
{ 
    
   
    public partial class addfriend : Form
    {

        //实例化QQ用户逻辑类 方便后面的方法调用QQUserBLL类中方法（）
        private QQUserBLL bll = new QQUserBLL();
        private string _qq = string.Empty;
        public addfriend(string qq)
        {
            _qq = qq;//qq传值
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           


            //获取用户输入的QQ号或关键字
            string key = this.textkey.Text.Trim();

            //在界面获取到查找的数据  【this.ckzaixian.Checked用来判断 在线是否被勾选】
            List<QQUserEntity> list = bll.GetUserListByLike(key, this.ckzaixian.Checked);

            //把查找到的数据显示到页面控件上（ListView）
            this.listView1.Items.Clear();//清空原有数据
            for (int i = 0; i < list.Count; i++)
            {
                QQUserEntity user = list[i];//拆箱操作（从list中取出，实体类对象）
                //把对象中的值 添加到ListView 的Items集合中 
                ListViewItem item = new ListViewItem();
                item.Text = user.Qq号;
                item.ImageIndex = i;//设置头像
               item.SubItems.Add(user.Qq昵称);
               item.SubItems.Add(user.Qq性别);
              int age = DateTime.Now.Year - user.Qq生日.Year;//现在的年份-生日年份
              item.SubItems.Add(age.ToString());
                item.SubItems.Add(user.Qq星座);       
               item.SubItems.Add(user.Qq是否允许被添加好友);
                //把封装好的数据添加到每一行
                this.listView1.Items.Add(item);
            }
        }


        //添加好友
        private void tianjia_Click(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.Count > 0)
            {
                //现获取用户被选中那一条数据的好友QQ号
                string fqq = this.listView1.SelectedItems[0].Text.Trim();

                //先判断用户是否允许被添加好友
                string isadd = this.listView1.SelectedItems[0].SubItems[5].Text.Trim();
                if (isadd == "是")
                {

                    //判断申请数据是否在数据库中存在
                    if (bll.GetQQUserFriendList(_qq, fqq))
                    {
                        if (bll.AddFriend(_qq, fqq, 1))//第一次添加好友申请信息 默认值为1
                        {
                            MessageBox.Show("添加好友申请已发送，等待对方回复！", "添加好友", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {

                            MessageBox.Show("申请添加好友失败，请稍后再试！", "添加好友", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                    }
                    else
                    {
                        MessageBox.Show("已添加过好友申请，无需重复添加(也有可能已被加入黑名单)！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    MessageBox.Show("对方不允许任何人添加自己为好友！", "拒绝添加", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {

                MessageBox.Show("请选择要添加的好友！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
        }


        //删除好友
        private void shanchu_Click(object sender, EventArgs e)
        {
            this.Close();//关闭窗体
        }



        //回车查看好友

        private void txtkey_KeyDown(object sender, KeyEventArgs e)
        {
            //判断用户摁的是否为 Enter键
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e); //直接调用查询按钮函数
            }
        }

        
        // 下方按钮添加好友
       
        



       //关闭
        private void guanbi_Click(object sender, EventArgs e)
        {
            this.Close();//关闭窗体
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //播放声音
            new SoundPlayer("system.wav").Play();

        }

        private void 添加好友ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tianjia_Click(sender, e);
        }

        private void 详细信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new userxinxi(this.listView1.SelectedItems[0].Text.Trim()).ShowDialog();//弹出页面
        }

        private void 屏蔽ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in this.listView1.SelectedItems)
            {
                //item.Index 是用来获取索引的
                this.listView1.Items.RemoveAt(item.Index);//根据选中行的索引移除对应的条数

            }
        }

        

        private void textkey_MouseClick(object sender, MouseEventArgs e)
        {
            if (textkey.Text == "QQ号/昵称/姓名")
            {
                this.textkey.Text = "";   
            }
        }
    }
}
