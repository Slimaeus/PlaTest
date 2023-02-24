using Microsoft.AspNet.Identity;
using PlaTest.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlaTest.Api.Data
{
    public class AppUserManager : UserManager<AppUser>
    {
        public AppUserManager(IUserStore<AppUser> store) : base(store)
        {
        }
    }
}