using Microsoft.AspNetCore.Mvc;
using ShareSocialMedia_2.Models;
using System.Diagnostics;

namespace ShareSocialMedia_2.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Sharer()
        {

            return View("../Views/Home/SharerPage");
        }
        [HttpGet]
        public IActionResult BtnFacebook()
        {

            string UrlFacebook = Url.Action("Sharer", "Home", null,Request.Scheme);
            string facebookSharerLink = $"https://www.facebook.com/sharer/sharer.php?u={UrlFacebook}";

            return Json(facebookSharerLink);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}