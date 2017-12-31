using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;

namespace CodeNightApi.Controllers
{
    public class HomeController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var a = new {
                        id = 15,
                        ad = "Selcuk",
                        Soyad = "Akşar"
            };
            string myContent = JsonConvert.SerializeObject(a);
            return  new HttpResponseMessage() {Content=new StringContent(myContent)};
        }
    }
}
