using CodeNight.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;
using System.Text;

namespace CodeNightApi.Controllers
{
    public class TestController : ApiController
    {
        // GET: api/Test
        public  HttpResponseMessage Get()
        {

            DatabaseContext db = new DatabaseContext();
            db.Configuration.LazyLoadingEnabled = false;
            var shares = db.Shares
               .OrderByDescending(x => x.CreatedDate).ToList();
            var myContent = JsonConvert.SerializeObject(shares);
            return new HttpResponseMessage()  { Content =new StringContent( myContent, Encoding.UTF8, "application/json" )};

        }

        // GET: api/Test/5
        public HttpResponseMessage Get(int id)
        {
            DatabaseContext db = new DatabaseContext();
            db.Configuration.LazyLoadingEnabled = false;
            var shares = db.Shares.Where(x=>x.Id==id)
               .OrderByDescending(x => x.CreatedDate).ToList();
            var myContent = JsonConvert.SerializeObject(shares);
            return new HttpResponseMessage() { Content = new StringContent(myContent, Encoding.UTF8, "application/json") };

        }

        // POST: api/Test
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Test/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Test/5
        public void Delete(int id)
        {
        }
    }
}
