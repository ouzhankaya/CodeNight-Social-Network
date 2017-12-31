using CodeNight.Entities.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CodeNight.BusinessLayer;

namespace CodeNightApi.Controllers
{
    public class UserController : ApiController
    {
        // GET: api/User
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/User/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/User
        public void Post(RegisterViewModel data)
        {
            UserManager myuserManager = new UserManager();
            myuserManager.UserRegister(data);
        }
        [HttpGet]
        [Route("api/User/Login/{id:int}")]
        public Boolean Login(int x)
        {
            return true;
        }
        // PUT: api/User/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/User/5
        public void Delete(int id)
        {
        }
    }
}
