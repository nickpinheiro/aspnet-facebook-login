using AspNet.Facebook.Web.Mvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Diagnostics;

namespace AspNet.Facebook.Web.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppSettings _appSettings;

        public HomeController(ILogger<HomeController> logger, IOptions<AppSettings> appSettings)
        {
            _logger = logger;
            _appSettings = appSettings.Value;
        }

        public IActionResult Index()
        {
            HomeViewModel homeViewModel = new HomeViewModel()
            {
                FacebookAppId = _appSettings.FacebookAppId,
                FacebookRedirectUri = _appSettings.FacebookRedirectUri
            };

            return View(homeViewModel);
        }

        public IActionResult Privacy()
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
