using MyQQDAL;
using MyQQModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQQBLL
{
    public class QQUserBLL
    {
        //实例化QQuserdal 数据访问层
        QQUserDAL dal = new QQUserDAL();

        
        public bool AddQQUser(QQUserEntity user)
        {
            return dal.AddQQUser(user);
        }
        //用户登录
        public bool IsUser(string uid, string pwd)
        {
            DataSet ds = dal.IsUser(uid, pwd);
            //判断ds数据集中是否存在数据
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                return true;

            }
            else
            {
                return false;
            }
        }


        // 查找好友

        public List<QQUserEntity> GetUserListByLike(string key, bool ck)
        {
                     
            DataSet ds = dal.GetUserListByLike(key, ck);
            List<QQUserEntity> list = new List<QQUserEntity>();
            //通过循环遍历ds数据集中的所有数据 封装到List集合中 并返回出去
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                QQUserEntity user = new QQUserEntity();
                user.Qq号 = ds.Tables[0].Rows[i]["账号"].ToString();
                user.Qq昵称 = ds.Tables[0].Rows[i]["昵称"].ToString();
                user.Qq性别 = ds.Tables[0].Rows[i]["性别"].ToString();
                user.Qq星座 = ds.Tables[0].Rows[i]["星座"].ToString();
                user.Qq生日 = DateTime.Parse(ds.Tables[0].Rows[i]["生日"].ToString());
                user.Qq是否允许被添加好友 = ds.Tables[0].Rows[i]["是否允许被添加好友"].ToString();
                

                list.Add(user);
            }
            return list;//返回数据

        }


        //获取QQ基本信息

        public QQUserEntity GetQQUserInfo(string qq)
        {
            DataSet ds = dal.GetQQUserInfo(qq);
            //判断ds数据集中是否存在数据， ds.Tables[0].Rows.Count 获取条数
            if (ds != null && ds.Tables[0].Rows.Count == 1)
            {

                QQUserEntity user = new QQUserEntity();
                user.Qq号 = ds.Tables[0].Rows[0]["账号"].ToString();
                user.Qq姓名 = ds.Tables[0].Rows[0]["姓名"].ToString();
                user.Qq昵称 = ds.Tables[0].Rows[0]["昵称"].ToString();
                user.Qq性别 = ds.Tables[0].Rows[0]["性别"].ToString();
                user.Qq星座 = ds.Tables[0].Rows[0]["星座"].ToString();
                user.Qq生日 = DateTime.Parse(ds.Tables[0].Rows[0]["生日"].ToString());
                user.Qq是否允许被添加好友 = ds.Tables[0].Rows[0]["是否允许被添加好友"].ToString();
                user.Qq手机号 = ds.Tables[0].Rows[0]["手机号"].ToString();
                user.Qq省_编号 = ds.Tables[0].Rows[0]["省名称"].ToString();
                user.Qq市_编号 = ds.Tables[0].Rows[0]["市名称"].ToString();
                user.Qq区_编号 = ds.Tables[0].Rows[0]["区名称"].ToString();
                user.Qq详细地址 = ds.Tables[0].Rows[0]["详情地址"].ToString();
                user.Qq头像 = ds.Tables[0].Rows[0]["QQ头像"].ToString();
                user.Qq个性签名 = ds.Tables[0].Rows[0]["个性签名"].ToString();

                return user;
            }

            return null;
        }

        // 提交添加好友申请
        /// 提交添加好友申请
        /// </summary>
        /// <param name="qq">自己的QQ</param>
        /// <param name="fqq">要添加好友QQ</param>
        /// <returns>true申请成功，false申请失败</returns>
       

        public bool AddFriend(string qq, string fqq, int state)
        {
            return dal.AddFriend(qq, fqq, state);
        }

        // 查询添加好友信息是否存在相同的申请记录

        public bool GetQQUserFriendList(string qq, string fqq)
        {
            DataSet ds = dal.GetQQUserFriendList(qq, fqq);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                //状态:  1申请中等待处理   2、已读状态 3、同意为好友 4、被拒绝添加好友 5、黑名单 

                string addstate = ds.Tables[0].Rows[0]["添加状态_编号"].ToString();
                if (addstate == "4")
                {
                    return true;//如果查询出来的好友申请记录状态为4 说明被对方拒绝过，可以再次申请添加 
                }
                else if (addstate == "5")
                { //黑名单永远无法添加她为好友
                    return false;
                }
            }
            else
            {
                return true; //如果添加好友申请表中不存在 咱俩的好友申请记录，可以被认定为第一申请添加好友
            }
            return false;
        }


        /// <summary>
        /// 获取我的QQ好友请求信息
        /// </summary>
        /// <param name="qq">我的QQ号</param>
        /// <returns>返回所有请求信息</returns>
        public List<Friend> GetQQFriendList(string qq)
        {
            DataSet ds = dal.GetQQFriendList(qq);
            int count = ds.Tables[0].Rows.Count;//获取数据库中返回的总条数
            if (ds != null && count > 0)
            {

                List<Friend> list = new List<Friend>();//创建一个集合对象 
                for (int i = 0; i < count; i++)
                {
                    Friend f = new Friend();//实例化实体类
                    f.Qq好友编号 = int.Parse(ds.Tables[0].Rows[i]["好友编号"].ToString());
                    f.Qq我的QQ = ds.Tables[0].Rows[i]["我的QQ"].ToString();
                    f.Qq好友QQ = ds.Tables[0].Rows[i]["好友QQ"].ToString();
                    f.Qq所属组_编号 = int.Parse(ds.Tables[0].Rows[i]["所属组_编号"].ToString());
                    f.Qq添加状态_编号 = int.Parse(ds.Tables[0].Rows[i]["添加状态_编号"].ToString());
                    f.Qq申请添加时间 = DateTime.Parse(ds.Tables[0].Rows[i]["申请添加时间"].ToString());
                    f.QQ昵称 = ds.Tables[0].Rows[i]["昵称"].ToString();//额外添加列 方便前台读取数据
                    list.Add(f);
                }

                return list;    //返回数据
            }
            return null;

        }

        /// <summary>
        /// 获取我的QQ好友列表
        /// </summary>
        /// <param name="qq">我的QQ号</param>
        /// <returns>所有好友信息</returns>
        public List<Friend> GetQQFriendListAll(string qq)
        {
            DataSet ds = dal.GetQQFriendListAll(qq);//********* 调用的方法不一样
            int count = ds.Tables[0].Rows.Count;//获取数据库中返回的总条数
            if (ds != null && count > 0)
            {
                List<Friend> list = new List<Friend>();//创建一个集合对象 
                for (int i = 0; i < count; i++)
                {
                    Friend f = new Friend();//实例化实体类
                    f.Qq好友编号 = int.Parse(ds.Tables[0].Rows[i]["好友编号"].ToString());
                    f.Qq我的QQ = ds.Tables[0].Rows[i]["我的QQ"].ToString();
                    f.Qq好友QQ = ds.Tables[0].Rows[i]["好友QQ"].ToString();
                    f.Qq所属组_编号 = int.Parse(ds.Tables[0].Rows[i]["所属组_编号"].ToString());
                    f.QQ昵称 = ds.Tables[0].Rows[i]["昵称"].ToString();//额外添加列 方便前台读取数据
                    f.QQ头像 = ds.Tables[0].Rows[i]["QQ头像"].ToString(); //额外添加列 方便前台读取数据
                    list.Add(f);
                }
                return list;    //返回数据
            }
            return null;

        }

        /// <summary>
        /// 根据添加好友申请记录编号“好友编号”更新 添加状态_编号
        /// </summary>
        /// <param name="id">好友编号</param>
        /// <param name="state">要被更新的状态 1默认为未读 、2已读 、3同意、4拒绝</param>
        /// <returns>true更新成功  false更新失败</returns>
        public bool UpdateQQFriendState(int id, int state)
        {

            return dal.UpdateQQFriendState(id, state);

        }

        //删除好友
        public bool DeleteQQFriend(string id)
        {

            
            return dal.DeleteQQFriend(id);
        }


        // 获取好友分组信息
        public DataSet GetFriendListInfo(string qq)
        {
            
            return dal.GetFriendListInfo(qq);
        }



        /// <summary>
        /// 根据自己QQ号加载 所属组
        /// </summary>
        /// <param name="qq">自己登录的QQ号</param>
        /// <returns></returns>
        public DataTable GetQQGroup(string qq)
        {
            DataSet ds = dal.GetQQGroup(qq);//调用业务逻辑层
            int count = ds.Tables[0].Rows.Count;//获取数据库中返回的总条数
            if (ds != null && count > 0)
            {
                return ds.Tables[0];//返回一张表 DataTable
            }
            return null;
        }
    }
}
