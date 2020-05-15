using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.AspNet.Identity; // this will help us get the extension we need to get the info we want about the user

namespace TRMDataManager.Controllers
{
    [Authorize]
    public class ValuesController : ApiController
    {
        // GET api/values
        //public IHttpActionResult Get()
        //{
        //    string userId = RequestContext.Principal.Identity.GetUserId();

        //    // The benefit of wrapping it in Ok() is that it provides you different options
        //    // that you can send back.
        //    // Such as further specify what response you send back.
        //    // The downside is that you won't know what data type it returns by reading the source code at a glance.
        //    // So this provides you more control over your result list, 
        //    // however you can use the previous IEnumerable result value and just return the string.
        //    return Ok(new string[] { "value1", "value2", userId });
        //}

        // GET api/values
        public IEnumerable<string> Get()
        {
            string userId = RequestContext.Principal.Identity.GetUserId();

            return new string[] { "value1", "value2", userId };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
