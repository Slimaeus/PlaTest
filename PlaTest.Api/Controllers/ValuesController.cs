using PlaTest.Api.Data;
using PlaTest.Api.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace PlaTest.Api.Controllers
{
    public class ValuesController : ApiController
    {
        private readonly AppUserManager _userManager;

        public ValuesController(AppUserManager userManager)
        {
            _userManager = userManager;
        }
        // GET api/values
        public IEnumerable<string> Get()
        {
            yield return ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return _userManager.Users.FirstOrDefault().UserName;
        }

        // POST api/values
        public async Task PostAsync([FromBody] string value)
        {
            var user = new AppUser
            {
                UserName = "thai",
                Email = "thai@mail.com",
                DisplayName = "Thai"
            };
            await _userManager.CreateAsync(user, "P@ssword");
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
