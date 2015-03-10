using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Omu.ValueInjecter;
using System.Web.Mvc;
using MvcCarManagerment.Models;
using WebMatrix.WebData;
using System.Web.Security;

namespace MvcCarManagerment.Areas.Admin.Controllers
{
    public class LogionController : Controller
    {
        //
        // GET: /Admin/Logion/

        public ActionResult Index()
        {
            return RedirectToAction("UserLogion");
        }


        /// <summary>
        /// 用户登录
        /// </summary>
        /// <returns></returns>
        [AllowAnonymous]
        public ActionResult UserLogion()
        {
            return View();
        }

        /// <summary>
        /// 用户登录
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult UserLogion(UserModel model)
        {
            if (ModelState.IsValid)
            {
                YuanChen.BLL.UsersLogion method = new YuanChen.BLL.UsersLogion();
                bool bo = method.Exist(model.UserName.Trim(), model.UserPwd.Trim());
                if (bo)
                {
                    //HttpCookie acookie = new HttpCookie("User");
                    //acookie.Values["name"] = model.UserName.Trim();
                    ////acookie.Values["last"] = "a";
                    //acookie.Expires = DateTime.Now.AddDays(1);
                    //Response.Cookies.Add(acookie);
                    Session["User"] = model.UserName.Trim();
                    FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(
                          1,
                          model.UserName.Trim(),
                          DateTime.Now,
                          DateTime.Now.AddMinutes(30),
                          false,
                          "manager"
                          );
                    // generate new identity
                    FormsIdentity identity = new FormsIdentity(ticket);
                    HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, FormsAuthentication.Encrypt(ticket));
                    // write to client.
                    Response.Cookies.Add(cookie);

                    return RedirectToAction("Index", "AboutManager", new { area = "Admin" });
                }
            }

            // 如果我们进行到这一步时某个地方出错，则重新显示表单
            ModelState.AddModelError("", "提供的用户名或密码不正确。");
            return View(model);
        }


        //
        // GET: /Account/Register

        [AllowAnonymous]
        public ActionResult Register()
        {
            RegisterModel model = new RegisterModel();
            return View(model);
        }

        //
        // POST: /Account/Register

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                // 尝试注册用户
                try
                {
                    //WebSecurity.CreateUserAndAccount(model.UserName, model.Password);
                    //WebSecurity.Login(model.UserName, model.Password);
                    YuanChen.Model.UsersLogion userinfo = new YuanChen.Model.UsersLogion();
                    YuanChen.BLL.UsersLogion method = new YuanChen.BLL.UsersLogion();
                    bool bo = method.Exist(model.UserName.Trim());
                    if (bo == false)
                    {
                        userinfo.UserName = model.UserName;
                        userinfo.UserPwd = model.Password;
                        method.Add(userinfo);
                        return RedirectToAction("Index", "Logion", new { area = "" });
                    }
                    else
                    {
                        ModelState.AddModelError("", "用户名已存在。请输入其他用户名。");
                    }

                }
                catch (MembershipCreateUserException e)
                {
                    ModelState.AddModelError("", ErrorCodeToString(e.StatusCode));
                }
            }

            // 如果我们进行到这一步时某个地方出错，则重新显示表单
            return View(model);
        }

        [AllowAnonymous]
        public ActionResult ModifyUser()
        {
            UserModel model = new UserModel();
            return View(model);
        }


        public ActionResult ModifyUser(UserModel model)
        {
            if (ModelState.IsValid)
            {
                YuanChen.BLL.UsersLogion method = new YuanChen.BLL.UsersLogion();
                YuanChen.Model.UsersLogion user = new YuanChen.Model.UsersLogion();
                user.InjectFrom(model);
                if (!string.IsNullOrEmpty(user.UserName))
                {
                    var record = method.GetModelList("");
                    if (record != null && record.Count > 0)
                    {
                        var re = record.Where(e => e.UserName == model.UserName.Trim()).FirstOrDefault();
                        if (re != null)
                        {
                            user.UserID = re.UserID;
                        }
                    }
                }
                bool bo = method.Update(user);
                if (!bo)
                {
                    // 如果我们进行到这一步时某个地方出错，则重新显示表单
                    ModelState.AddModelError("", "提供的用户名或密码不正确。");
                    return View(model);
                }

            }

            return View(model);
        }


        //
        // POST: /Logion/LogOff

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LogOff()
        {
            //WebSecurity.Logout();

            HttpCookie acookie = new HttpCookie("User");
            acookie.Expires = DateTime.Now.AddDays(-1);
            Response.Cookies.Add(acookie);
            //return RedirectToAction("Index", "Logion");
            Session["User"] = null;
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Logion", new { area = "" });
        }



        private static string ErrorCodeToString(MembershipCreateStatus createStatus)
        {
            // 请参见 http://go.microsoft.com/fwlink/?LinkID=177550 以查看
            // 状态代码的完整列表。
            switch (createStatus)
            {
                case MembershipCreateStatus.DuplicateUserName:
                    return "用户名已存在。请输入其他用户名。";

                case MembershipCreateStatus.DuplicateEmail:
                    return "该电子邮件地址的用户名已存在。请输入其他电子邮件地址。";

                case MembershipCreateStatus.InvalidPassword:
                    return "提供的密码无效。请输入有效的密码值。";

                case MembershipCreateStatus.InvalidEmail:
                    return "提供的电子邮件地址无效。请检查该值并重试。";

                case MembershipCreateStatus.InvalidAnswer:
                    return "提供的密码取回答案无效。请检查该值并重试。";

                case MembershipCreateStatus.InvalidQuestion:
                    return "提供的密码取回问题无效。请检查该值并重试。";

                case MembershipCreateStatus.InvalidUserName:
                    return "提供的用户名无效。请检查该值并重试。";

                case MembershipCreateStatus.ProviderError:
                    return "身份验证提供程序返回了错误。请验证您的输入并重试。如果问题仍然存在，请与系统管理员联系。";

                case MembershipCreateStatus.UserRejected:
                    return "已取消用户创建请求。请验证您的输入并重试。如果问题仍然存在，请与系统管理员联系。";

                default:
                    return "发生未知错误。请验证您的输入并重试。如果问题仍然存在，请与系统管理员联系。";
            }
        }
    }
}
