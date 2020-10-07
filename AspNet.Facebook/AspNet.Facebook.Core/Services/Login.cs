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

        public static async Task<Models.Login.AccessToken> GetAccessTokenAsync(string facebookAppId, string facebookAppSecret, string facebookAppDomain, string code)
        {
            HttpResponseMessage response = await client.GetAsync(oauthBaseUri + "oauth/access_token?client_id=" + facebookAppId + "&client_secret=" + facebookAppSecret + "&redirect_uri=" + facebookAppDomain + "&code=" + code);
            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                string result = JToken.Parse(json).ToString();

                Models.Login.AccessToken accessToken = JsonConvert.DeserializeObject<Models.Login.AccessToken>(result);

                return accessToken;
            }

            return null;
        }
    }
}
