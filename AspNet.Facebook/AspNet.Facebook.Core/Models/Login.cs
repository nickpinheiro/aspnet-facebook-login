namespace AspNet.Facebook.Core.Models
{
    public class Login
    {
        public class AccessToken
        {
            public string access_token { get; set; }
            public string token_type { get; set; }
            public string expires_in { get; set; }
        }
    }
}
