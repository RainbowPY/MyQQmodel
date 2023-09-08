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
    public partial class Main : Form
    {
        public string _qq = string.Empty;
        //实例化业务逻辑对象
        QQUserBLL bll = new QQUserBLL();
        public Main(string qq)
        {
            this._qq = qq;
            
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            addfriend hy = new addfriend(this._qq);
            hy.ShowDialog();//弹出添加好友界面
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();//退出qq
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            //第一步查询数据库中是否有我的未读消息
            QQUserBLL bll = new QQUserBLL();
            List<Friend> list = bll.GetQQFriendList(this._qq);//把自己登录的QQ交给GetQQFriendList方法去查询所有好友添加请求数据
            if (list != null)
            {

                //循环提取添加消息
                foreach (Friend f in list)
                {

                    #region 弹出消息

                    //1、弹出窗体
                    //Message ms = new Message();
                    //ms.Show();

                    //2、播放声音
                    new System.Media.SoundPlayer("system.wav").Play();

                    //3、更新已读状态
                    bll.UpdateQQFriendState(f.Qq好友编号, 2);//2状态为已读

                    //4、控制弹出窗体的位置
                    //通过Point类获取电脑工作区的屏幕x，y宽度，- 弹出窗口的宽度作为定向的X轴位置，高度获取屏幕高度作为Y定向位置
                    Message ms = new Message(_qq, f.Qq好友编号, f.QQ昵称, f.Qq我的QQ); //f.Qq我的QQ 就是对方申请加你为好友的人
                    Point p = new Point(Screen.PrimaryScreen.WorkingArea.Width - ms.Width, Screen.PrimaryScreen.WorkingArea.Height);
                    ms.PointToClient(p);//通过Message窗口的 Ms对象 指定弹出去的坐标位置
                    ms.Location = p;
                    ms.Show();
                    //写个循环把窗体往上浮动
                    for (int i = 0; i < ms.Height; i++)
                    {
                        ms.Location = new Point(p.X, p.Y - i);
                    }

                    #endregion



                }

            }
            }

        private void Main_Load(object sender, EventArgs e)
        {
            //1、页面已加载首次出现的位置
            this.Left = 800;//距离左侧800px
            this.Top = 30;//距离上侧30px

            //2、加载个人基本信息
            QQUserEntity user = new QQUserBLL().GetQQUserInfo(_qq);
            this.lab个性签名.Text = user.Qq个性签名;
            this.lab昵称.Text = user.Qq昵称;
            this.lab账号.Text = user.Qq号;


            //3、读取数据库加载好友列表
            List<Friend> list = bll.GetQQFriendListAll(_qq);//根据登录的QQ查询属于自己的好友


            //4、获取组 
            DataTable dt = bll.GetQQGroup(_qq);

            //开始检测listView1添加数据
            this.listView2.BeginUpdate();

            if (dt != null)
            {
                //循环创建组
                for (int j = 0; j < dt.Rows.Count; j++)
                {
                    int gid = int.Parse(dt.Rows[j]["组编号"].ToString());
                    string gname = dt.Rows[j]["组名称"].ToString();
                    this.listView2.Groups.Add(new ListViewGroup(gname, HorizontalAlignment.Center));

                    //循环往组中添加数据
                    for (int i = 0; i < list.Count; i++)
                    {
                        Friend f = list[i];//把每条数据读取出来  
                        if (f.Qq所属组_编号 == gid) //判断好友是否属于这一组
                        {
                            ListViewItem lvi = new ListViewItem();//创建一个新的ListViewItem项 用来为每一个QQ好友存放数据 
                            lvi.ImageIndex = int.Parse(f.QQ头像);//设置一个头像索引
                            lvi.Text = f.QQ昵称 + f.Qq好友QQ; //设置一个名称 索引0
                            lvi.SubItems.Add(f.Qq好友QQ);//增加一个数据绑定（好友QQ） 索引1
                            lvi.SubItems.Add(f.QQ个性签名);//增加一个个性签名的绑定咧 索引2
                            this.listView2.Items.Add(lvi);
                            this.listView2.Groups[j].Items.Add(lvi);   ////把每一个好友信息都添加到ListView中显示出来 
                        }
                    }

                }

                this.listView2.EndUpdate(); //结束检测listView1 提交数据
            }


        }

        private void 查看好友信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new userxinxi(this.listView2.SelectedItems[0].SubItems[1].Text.Trim()).ShowDialog();//弹出页面
        }

        private void 删除好友ToolStripMenuItem_Click(object sender, EventArgs e)
        {


            bll.DeleteQQFriend(this.listView2.SelectedItems[0].SubItems[1].Text.Trim());
            
        }

        private void 发送消息ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            new liaotian().Show();
           
        }

        private void listView2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //获取被用户双击头像的那个QQ好友、 号码
            string fqq = this.listView2.SelectedItems[0].SubItems[1].Text.Trim();//获取QQ
            string nicheng = this.listView2.SelectedItems[0].Text;//获取昵称
            string gexingqianming = this.listView2.SelectedItems[0].SubItems[2].Text.Trim();//获取个性签名

            //弹出聊天框
            liaotian ms = new liaotian();

            //传值到SendMessage窗体页面
            ms.Qq = fqq;//好友QQ
            ms.Nicheng = nicheng; //好友昵称
            ms.Gexingqianming = gexingqianming; //好友个性签名

            ms.Myqq = _qq;//传入自己的QQ
            ms.Mynicheng = lab昵称.Text.Trim();//传入自己的昵称
            ms.Mygexingqianming = lab个性签名.Text.Trim();//传入自己的个性签名

            ms.Show();//弹出窗体
        }
    }
}
