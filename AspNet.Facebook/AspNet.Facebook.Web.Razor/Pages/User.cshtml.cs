using System.Threading.Tasks;
using AspNet.Facebook.Core.Models;
using AspNet.Facebook.Web.Razor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Options;

namespace AspNet.Facebook.Web.Razor.Pages
{
    [IgnoreAntiforgeryToken]
    public class UserModel : PageModel
    {
        private readonly AppSettings _appSettings;

        public UserModel(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;
        }

        [BindProperty]
        public User FacebookUser { get; set; }

        public async Task<PageResult> OnGetAsync(string code)
        {
            Login.AccessToken accessToken = await Core.Services.Login.GetAccessTokenAsync(_appSettings.FacebookAppId, _appSettings.FacebookAppSecret, _appSettings.FacebookRedirectUri, code);

            FacebookUser = await Core.Services.Graph.GetUserAsync(accessToken.access_token);

            return Page();
        }
    }
}
