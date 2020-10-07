using AspNet.Facebook.Core.Models;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace AspNet.Facebook.Core.Services
{
    public class Graph
    {
        private static HttpClient client = new HttpClient();
        private const string oauthBaseUri = "https://graph.facebook.com/";

        public static async Task<User> GetUserAsync(string accessToken)
        {
            HttpResponseMessage response = await client.GetAsync(oauthBaseUri + "me?fields=id,name,first_name,last_name,email,picture&access_token=" + accessToken);

            if (response.IsSuccessStatusCode)
            {
                string strJson = response.Content.ReadAsStringAsync().Result;
                User user = JsonConvert.DeserializeObject<User>(strJson);
                user.access_token = accessToken;

                return user;
            }
    
            return null;
        }
    }
}
