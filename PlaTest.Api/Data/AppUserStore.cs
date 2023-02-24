using Microsoft.AspNet.Identity.EntityFramework;
using PlaTest.Api.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PlaTest.Api.Data
{
    public class AppUserStore : UserStore<AppUser>
    {
        public AppUserStore(DataContext context) : base(context)
        {
        }
    }
}