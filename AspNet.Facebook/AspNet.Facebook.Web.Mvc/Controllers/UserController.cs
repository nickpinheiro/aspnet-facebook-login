using AspNet.Facebook.Core.Models;
using AspNet.Facebook.Web.Mvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace AspNet.Facebook.Web.Mvc.Controllers
{
    public class UserController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppSettings _appSettings;

        public UserController(ILogger<HomeController> logger, IOptions<AppSettings> appSettings)
        {
            _logger = logger;
            _appSettings = appSettings.Value;
        }

        public async System.Threading.Tasks.Task<IActionResult> IndexAsync(string code)
        {
            Login.AccessToken accessToken = await Core.Services.Login.GetAccessTokenAsync(_appSettings.FacebookAppId, _appSettings.FacebookAppSecret, _appSettings.FacebookRedirectUri, code);

            User user = await Core.Services.Graph.GetUserAsync(accessToken.access_token);

            return View(user);
        }
    }
}
