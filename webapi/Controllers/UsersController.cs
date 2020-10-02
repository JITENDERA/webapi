using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;
using webapi.Models;

namespace webapi.Controllers
{
    [EnableCors(origins:"*",headers:"*",methods:"*")]
    public class UsersController : ApiController
    {

        private User[] users = new User[]
        {
            new User { id = 1, name = "Jitendera", email = "jpsingh@ivp.in", phone = "9818167289", role = 1},
            new User { id = 2, name = "JP", email = "jpsingh@ivp.in", phone = "9818167289", role = 1},
            new User { id = 3, name = "Pratap", email = "jpsingh@ivp.in", phone = "9818167289", role = 2},
            new User { id = 4, name = "Singh", email = "jpsingh@ivp.in", phone = "9818167289", role = 3},
        };


        //GET: api/Users
        [ResponseType(typeof(IEnumerable<User>))]
        public IEnumerable<User>Get()
        {
            return users;
        }

        //GET: api/Users/5
        public IHttpActionResult Get(int id)
        {
            var product = users.FirstOrDefault((p) => p.id == id);
            if(product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        // GET: api/Users
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET: api/Users/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST: api/Users
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT: api/Users/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE: api/Users/5
        //public void Delete(int id)
        //{
        //}
    }
}
