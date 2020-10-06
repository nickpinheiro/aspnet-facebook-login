namespace AspNet.Facebook.Core.Models
{
    public class User
    {
        public string id { get; set; }
        public string access_token { get; set; }
        public string name { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string username { get; set; }
        public Picture picture { get; set; }

        public class Location
        {
            public string id { get; set; }
            public string name { get; set; }
        }

        public class Picture
        {
            public Data data { get; set; }
        }

        public class Data
        {
            public bool is_silhouette { get; set; }
            public string url { get; set; }
        }
    }
}
