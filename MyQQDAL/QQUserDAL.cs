using MyQQModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQQDAL
{



    /// <summary>
    /// QQ用户表的数据访问层
    /// </summary>
    public class QQUserDAL:DBSqlHelp
    {

        /// <summary>
        /// 对QQ用户表的添加方法
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool AddQQUser(QQUserEntity user)
        {
            //拼接TSQL执行命令
            string sql = "insert into 用户(账号,密码,昵称,姓名,性别,生日,星座,手机号,省_编号,市_编号,区_编号,详情地址)  values('" + user.Qq号 + "','" + user.Qq密码 + "','" + user.Qq昵称 + "','" + user.Qq姓名 + "','" + user.Qq性别 + "','" + user.Qq生日 + "','" + user.Qq星座 + "','" + user.Qq手机号 + "','" + user.Qq省_编号 + "','" + user.Qq市_编号 + "','" + user.Qq区_编号 + "','" + user.Qq详细地址 + "')";
            // 执行命令并返回执行结果
             return SQL_ExecuteNonQuery(sql);
        }
        //用户登录
        public DataSet IsUser (string uid ,string pwd)
        {
            string sql = "select * from 用户 where 账号 = '" + uid + "'and 密码= ’" + pwd + "'";
            return SQL_GetData(sql);
        }

        //好友添加查找

        public DataSet GetUserListByLike(string key, bool ck)
        {

            string sql = "select * from 用户 where (账号='" + key + "' or 昵称 like '%" + key + "%' or 手机号='" + key + "')";
            if (ck == true)
            { //判断是否查询在线

                sql += " and (QQ状态_编号=1)";
            }

            return SQL_GetData(sql);
        }


        // 提交添加好友申请
        public bool AddFriend(string qq, string fqq, int state)
        {
            string sql = "insert into QQ好友([我的QQ],[好友QQ],[添加状态_编号])values('" + qq + "','" + fqq + "'," + state + ")";
            return SQL_ExecuteNonQuery(sql);
        }



        // 查询添加好友信息是否存在相同的申请记录
        public DataSet GetQQUserFriendList(string qq, string fqq)
        {
            string sql = "select * from QQ好友 where 我的QQ='" + qq + "' and 好友QQ='" + fqq + "'";
            return SQL_GetData(sql);
        }



        // 根据QQ号获取基本信息
        public DataSet GetQQUserInfo(string qq)
        {

            string sql = "select * from 用户 as a left join 省 as b  on  a.省_编号=b.省_编号  left join  市 as c on a.市_编号=c.市_编号  left join 区 as d on a.区_编号=d.区_编号 left join QQ在线状态 e on a.QQ状态_编号=e.状态编号 where a.账号='" + qq + "'";
            return SQL_GetData(sql);
        }



        // <summary>
        /// 获取我的QQ好友请求信息
        /// </summary>
        /// <param name="qq">我的QQ号</param>
        /// <returns>返回所有请求信息</returns>
        public DataSet GetQQFriendList(string qq)
        {

            string sql = "select * from QQ好友 as a  left join 用户 as b  on a.我的QQ=b.账号 where 好友QQ='" + qq + "'and 添加状态_编号=1";
            return SQL_GetData(sql);
        }

        /// <summary>
        /// 获取我的QQ好友列表
        /// </summary>
        /// <param name="qq">我的QQ号</param>
        /// <returns>所有好友信息</returns>
        public DataSet GetQQFriendListAll(string qq)
        {
            string sql = "select 好友编号,所属组_编号,昵称,好友QQ, QQ头像,我的QQ  from QQ好友 as a left join 用户 as b on a.好友QQ=b.账号 where  我的QQ='" + qq + "' and 添加状态_编号 = 3";
            
            return SQL_GetData(sql);
        }



        /// <summary>
        /// 根据添加好友申请记录编号“好友编号”更新 添加状态_编号
        /// </summary>
        /// <param name="id">好友编号</param>
        /// <param name="state">要被更新的状态 1默认为未读 、2已读 、3同意、4拒绝</param>
        /// <returns>true更新成功  false更新失败</returns>
        public bool UpdateQQFriendState(int id, int state)
        {
            //
            string sql = "update  QQ好友 set 添加状态_编号=" + state + " where 好友编号=" + id;
            return SQL_ExecuteNonQuery(sql);
        }


        public bool DeleteQQFriend(string id) {

            string sql = "delete  from QQ好友 where 好友QQ = '" + id + "'";
            return SQL_ExecuteNonQuery(sql);
        }



        //获取好友分组信息
        public DataSet GetFriendListInfo(string qq)
        {
            string sql = "select * from QQ分组 where 所属QQ_编号 ='" + qq + "'";
            return SQL_GetData(sql);
        }



        /// <summary>
        /// 根据自己QQ号加载 所属组
        /// </summary>
        /// <param name="qq">自己登录的QQ号</param>
        /// <returns></returns>
        public DataSet GetQQGroup(string qq)
        {
            string sql = "select* from QQ分组 where 所属QQ_编号='" + qq + "'";
            return SQL_GetData(sql);
        }
    }
}
