using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNet.Facebook.Web.Razor.Models
{
    public class AppSettings
    {
        public string FacebookAppId { get; set; }
        public string FacebookAppSecret { get; set; }
        public string FacebookRedirectUri { get; set; }
    }
}
