using System.Web.Mvc;

namespace MS.Web.Controllers
{
    /// <summary>
    /// 首頁控制器
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// 首頁
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            ViewBag.Title = "首頁";
            return View();
        }
    }
}
