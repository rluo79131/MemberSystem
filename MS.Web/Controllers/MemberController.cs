using MS.Web.BLL;
using MS.Web.Models;
using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MS.Web.Controllers
{
    /// <summary>
    /// 會員控制器
    /// </summary>
    public class MemberController : Controller
    {
        /// <summary>
        /// 會員服務
        /// </summary>
        private readonly MemberService _memberService = new MemberService();

        /// <summary>
        /// 註冊頁面
        /// </summary>
        /// <returns></returns>
        public ActionResult Register()
        {
            ViewBag.Title = "註冊";
            return View();
        }

        /// <summary>
        /// 註冊
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Register(MemberRequest request)
        {
            var response = new ApiResponse();

            try
            {
                _memberService.Register(request);

                response.Result = true;
            }
            catch (Exception ex)
            {
                response.ErrorMessage = ex.ToString();
            }

            return Json(response);
        }

        /// <summary>
        /// 登入頁面
        /// </summary>
        /// <returns></returns>
        public ActionResult Login()
        {
            ViewBag.Title = "登入";
            return View();
        }

        /// <summary>
        /// 登入
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Login(MemberRequest request)
        {
            var response = new ApiResponse();

            try
            {
                var member = _memberService.GetMember(request.Account);

                if (member == null)
                {
                    response.ErrorMessage = "帳號不正確";
                }
                else if (member.Password != request.Password)
                {
                    response.ErrorMessage = "密碼不正確";
                }
                else
                {
                    request.Name = member.Name;
                    Authenticate(request);

                    response.Result = true;
                }
            }
            catch (Exception ex)
            {
                response.ErrorMessage = ex.ToString();
            }

            return Json(response);
        }

        /// <summary>
        /// 授權驗證
        /// </summary>
        /// <param name="request"></param>
        private void Authenticate(MemberRequest request)
        {
            var authTicket = new FormsAuthenticationTicket(1, request.Account, DateTime.Now, DateTime.Now.AddMinutes(30), true, request.Name, FormsAuthentication.FormsCookiePath);
            var cookie = new HttpCookie(FormsAuthentication.FormsCookieName, FormsAuthentication.Encrypt(authTicket));

            Response.Cookies.Add(cookie);
        }

        /// <summary>
        /// 登出
        /// </summary>
        /// <returns></returns>
        public ActionResult Logout()
        {
            Response.Cookies[FormsAuthentication.FormsCookieName].Expires = DateTime.Now.AddDays(-1);
            return RedirectToAction("Index", "Home");
        }
    }
}