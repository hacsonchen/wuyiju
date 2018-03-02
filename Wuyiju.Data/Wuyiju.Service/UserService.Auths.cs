using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wuyiju.Core;
using Wuyiju.DAL;
using Wuyiju.IDAL;
using Wuyiju.IService;
using Wuyiju.Model;

namespace Wuyiju.Service
{
    public partial class UserService
    {
        public User CheckUser(string username, string password)
        {
            var user = dao.GetByUsername(username);

            if (user == null)
                throw new ApplicationException("用户名或密码错误");

            if (user.Status != 1)
                throw new ApplicationException("此用户已经禁用了");

            if (!password.ToMD5().Equals(user.Password))
                throw new ApplicationException("用户名或密码错误");

            return user;
        }

        public int? InitUser(string mobile)
        {
            var user = new User();
            user.Name = mobile;
            user.Password = mobile.Substring(mobile.Length - 6);
            user.Mobile = mobile;
            user.Introducer = mobile;
            user.Login_Ip = "";

            try
            {

                //var obj = dao.GetByUsername(mobile);
                var lst = dao.GetList(new User.Query { Mobile = mobile });


                if (lst == null || lst.Count < 1)
                {
                    Register(user);
                    var users = dao.GetList(new User.Query { Mobile = mobile });
                    if (users == null || users.Count < 1)
                        return null;
                    else
                        return users[0].Id;
                }
                else
                {
                    return lst[0].Id;
                }

            }
            catch
            {
                return null;
            }


        }

        public int[] InitUser(string[] mobiles)
        {
            var lst = new List<int>();

            if (mobiles != null)
            {
                foreach (var mobile in mobiles)
                {
                    try
                    {
                        var id = InitUser(mobile);

                        if (id != null && id.HasValue)
                            lst.Add(id.Value);
                    }
                    catch
                    {

                    }
                }
            }

            return lst.ToArray();
        }

        public void Register(User user)
        {
            var obj = dao.GetByUsername(user.Name);

            if (obj != null)
                throw new ApplicationException("已经存在此用户名");

            user.Password = user.Password.ToMD5();

            if (ExistsMobile(user.Mobile))
                throw new ApplicationException("手机号码已占用");

            try
            {
                user.Pay_Password = "";
                user.Add_Time = DateTime.Now.ToTimeStamp2();
                user.Pay_Password = "";
                user.Realname = "";
                user.Email = "";
                user.Status = 1;
                user.Last_Time = 0;
                user.Login_Count = 0;
                user.Salt = "";
                user.Is_Email_Validated = 0;
                user.Is_Mobile_Validated = 0;
                user.Money = 0;
                user.Frozen_Money = 0;
                user.Money_Status = 0;
                user.Rank_Points = 0;
                user.Points = 0;
                user.Rank_Id = 0;
                user.Sex = 0;
                user.Brithday = "";
                user.Qq = "";
                user.Pwd_Question = "";
                user.Pwd_Answer = "";
                user.Login_Ip = "";
                dao.Insert(user);
            }
            catch (Exception ex)
            {
                log4net.LogManager.GetLogger("Error").Error("用户注册逻辑发生异常", ex);
                throw ex;
            }

        }

        public void ModifyInfo(User user)
        {
            using (var db = new DataContext())
            {

                var userDao = unity.GetInstance<IUserDAL>(db);
                var obj = userDao.GetByUsername(user.Name);

                obj.Brithday = user.Brithday;
                obj.Sex = user.Sex;
                obj.Qq = user.Qq;
                obj.Realname = user.Realname;
                obj.Mobile = user.Mobile;
                obj.Email = user.Email;
                obj.Is_Email_Validated = user.Is_Email_Validated;
                obj.Is_Mobile_Validated = user.Is_Mobile_Validated;

                try
                {
                    userDao.Update(obj);
                }
                catch (Exception ex)
                {
                    log4net.LogManager.GetLogger("Error").Error("用户注册逻辑发生异常", ex);
                }
            }

        }



        public void ChangePassword(string username, string old_pass, string new_pass)
        {
            using (var db = new DataContext())
            {

                var userDao = unity.GetInstance<IUserDAL>(db);

                var obj = userDao.GetByUsername(username);

                if (!old_pass.Equals(new_pass))
                    throw new ApplicationException("新密码不能与旧密码一致");

                if (obj == null)
                    throw new ApplicationException("不存在此用户名");

                if (!old_pass.ToMD5().Equals(obj.Password))
                    throw new ApplicationException("旧密码不正确");

                obj.Password = new_pass.ToMD5();

                try
                {

                    //开启事务
                    db.BeginTransaction();
                    //此处可支持多个DAL
                    userDao.Update(obj);

                    //提交事务
                    db.Commit();
                }
                catch (Exception ex)
                {
                    //出现异常事务回滚
                    db.Rollback();
                    Logger.GetLogger().Error("修改密码逻辑发生异常", ex);
                    throw new ApplicationException("系统异常,请稍候重试");
                }
            }
        }

        public void ForgetPassword(string mobile, string new_pass)
        {
            using (var db = new DataContext())
            {

                var userDao = unity.GetInstance<IUserDAL>(db);

                var obj = userDao.GetByMobile(mobile);


                if (obj == null)
                    throw new ApplicationException("不存在此手机号");

                obj.Password = new_pass.ToMD5();

                try
                {

                    //开启事务
                    db.BeginTransaction();
                    //此处可支持多个DAL
                    userDao.Update(obj);

                    //提交事务
                    db.Commit();
                }
                catch (Exception ex)
                {
                    //出现异常事务回滚
                    db.Rollback();
                    Logger.GetLogger().Error("忘记密码逻辑发生异常", ex);
                    throw new ApplicationException("系统异常,请稍候重试");
                }
            }
        }


        public void ForgetPayPassword(string mobile, string new_pass)
        {
            using (var db = new DataContext())
            {

                var userDao = unity.GetInstance<IUserDAL>(db);

                var obj = userDao.GetByMobile(mobile);


                if (obj == null)
                    throw new ApplicationException("不存在此手机号");

                obj.Pay_Password = new_pass.ToMD5();

                try
                {

                    //开启事务
                    db.BeginTransaction();
                    //此处可支持多个DAL
                    userDao.Update(obj);

                    //提交事务
                    db.Commit();
                }
                catch (Exception ex)
                {
                    //出现异常事务回滚
                    db.Rollback();
                    Logger.GetLogger().Error("忘记密码逻辑发生异常", ex);
                    throw new ApplicationException("系统异常,请稍候重试");
                }
            }
        }

        public void SetPaymentPwd(string username, string old_pass, string new_pass, string comfirm_pass)
        {
            using (var db = new DataContext())
            {

                var userDao = unity.GetInstance<IUserDAL>(db);

                var obj = userDao.GetByUsername(username);

                if (!new_pass.Equals(comfirm_pass))
                    throw new ApplicationException("两次密码不一致");

                if (obj == null)
                    throw new ApplicationException("不存在此用户名");


                if (!obj.Pay_Password.IsNullOrWhiteSpace() && !old_pass.IsNullOrEmpty() && !old_pass.ToMD5().Equals(obj.Pay_Password))
                {
                    throw new ApplicationException("原支付密码不正确");
                }

                obj.Pay_Password = new_pass.ToMD5();

                try
                {

                    //开启事务
                    db.BeginTransaction();
                    //此处可支持多个DAL
                    userDao.Update(obj);

                    //提交事务
                    db.Commit();
                }
                catch (Exception ex)
                {
                    //出现异常事务回滚
                    db.Rollback();
                    Logger.GetLogger().Error("修改支付密码逻辑发生异常", ex);
                    throw new ApplicationException("系统异常,请稍候重试");
                }
            }
        }

        public void SetPwdProtect(string username, string old_answer, string question, string answer, string con_answer)
        {
            using (var db = new DataContext())
            {

                var userDao = unity.GetInstance<IUserDAL>(db);

                if (answer.IsNullOrWhiteSpace())
                    throw new ApplicationException("问题答案不能留空");

                if (con_answer.IsNullOrWhiteSpace())
                    throw new ApplicationException("问题答案不能留空");

                if (!answer.Equals(con_answer))
                    throw new ApplicationException("两次答案不一致");

                var obj = userDao.GetByUsername(username);


                if (obj == null)
                    throw new ApplicationException("不存在此用户名");

                if (!obj.Pwd_Question.IsNullOrWhiteSpace())
                {
                    if (old_answer.IsNullOrWhiteSpace())
                        throw new ApplicationException("原问题答案不能留空");

                    if (!old_answer.Equals(obj.Pwd_Answer))
                        throw new ApplicationException("原问题答案不正确");
                }

                obj.Pwd_Question = question;
                obj.Pwd_Answer = answer;

                try
                {

                    //开启事务
                    db.BeginTransaction();
                    //此处可支持多个DAL
                    userDao.Update(obj);

                    //提交事务
                    db.Commit();
                }
                catch (Exception ex)
                {
                    //出现异常事务回滚
                    db.Rollback();
                    log4net.LogManager.GetLogger("Error").Error("修改密码逻辑发生异常", ex);
                    throw new ApplicationException("系统异常,请稍候重试");
                }
            }
        }

        public int TodayNewCount()
        {
            var today = DateTime.Now;
            var query = new Wuyiju.Model.User.Query
            {
                StartDate = new DateTime(today.Year, today.Month, today.Day, 0, 0, 0),
                EndDate = new DateTime(today.Year, today.Month, today.Day, 23, 59, 59)
            };

            return dao.GetCount(query);
        }
    }
}
