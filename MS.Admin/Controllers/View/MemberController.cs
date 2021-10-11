using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MS.Admin.Models;
using System.Diagnostics;

namespace MS.Admin.Controllers
{
    public class MemberController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public MemberController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Information()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
