using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using AngularJS.ContentAPI.Models;

namespace AngularJS.ContentAPI.Controllers
{
    [Route("users")]
    public class UsersController : ApiController
    {
        // GET: users
        [HttpGet]
        [ResponseType(typeof(User[]))]
        public HttpResponseMessage Get()
        {
            var result = new User[] {
                new User() {
                    Id = 1,
                    Name = "João Vitor Saraiva",
                    Email = "joao.vitor.saraiva@mock.com"
                },

                new User() {
                    Id = 2,
                    Name = "Jonatas Saraiva",
                    Email = "jonatas.saraiva@mock.com"
                }
            };

            return base.Request.CreateResponse (HttpStatusCode.OK, result);
        }

        // GET: api/Users/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Users
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Users/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Users/5
        public void Delete(int id)
        {
        }
    }
}
