using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SmallService.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values/Name
        public string Get(string id)
        {
            WebClient client = new WebClient();
            string result = "";
            // result = client.DownloadString("http://www.omdbapi.com/?t=" + id + "&r=xml&apikey=5b359aa9");
            result = client.DownloadString("http://www.omdbapi.com/?t=" + id + "&apikey=5b359aa9");
            return result.ToString();
        }

        public string Get(int a, int b)
        {
            int result = a + b;
            if(b > 0)
            {
                return a + " + " + b + " = " + result;
            }
            else
            {
                return a + " - " + Math.Abs(b) + " = " + result;
            }
        }


    }
}
