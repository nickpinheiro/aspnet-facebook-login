using AspNet.Facebook.Core.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace AspNet.Facebook.Core.Services
{
    public class Login
    {
        private static HttpClient client = new HttpClient();
        private const string oauthBaseUri = "https://graph.facebook.com/";

        public static async Task<User> GetAccessTokenAsync(string facebookAppId, string facebookAppSecret, string facebookAppDomain, string code)
        {
            string json = null;

            HttpResponseMessage response = await client.GetAsync(oauthBaseUri + "oauth/access_token?client_id=" + facebookAppId + "&client_secret=" + facebookAppSecret + "&redirect_uri=" + facebookAppDomain + "&code=" + code);
            if (response.IsSuccessStatusCode)
            {
                json = await response.Content.ReadAsStringAsync();
                string result = JToken.Parse(json).ToString();

                Models.Login.AccessToken accessToken = JsonConvert.DeserializeObject<Models.Login.AccessToken>(result);
                User user = await Graph.GetUserAsync(accessToken.access_token);

                return user;
            }

            return null;
        }

        public static async Task<string> GetExtendedAccessTokenAsync(string facebookAppId, string facebookAppSecret, string accessToken)
        {
            string extendedAccessToken;

            HttpResponseMessage response = await client.GetAsync("grant_type = fb_exchange_token & client_id = " + facebookAppId + " & client_secret = " + facebookAppSecret + " & fb_exchange_token = " + accessToken);

            if (response.IsSuccessStatusCode)
            {
                extendedAccessToken = await response.Content.ReadAsStringAsync();
                return extendedAccessToken;
            }

            return null;
        }
    }
}
