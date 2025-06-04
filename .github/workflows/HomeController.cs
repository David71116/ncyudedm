using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using 期末.Models;
 

namespace 期末.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

       
        public IActionResult 我喜歡的歌()
        {
            return View();
        }
        public IActionResult 聯絡我()
        {
            return View();
        }

        public IActionResult 作品()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [HttpPost]
        public IActionResult 聯絡我(ContactFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // 處理資料，例如儲存或寄送 Email
            ViewBag.Message = "感謝您的填寫，我會儘快與您聯繫！";

            ModelState.Clear(); // 清除欄位
            return View();
        }
    }
}

