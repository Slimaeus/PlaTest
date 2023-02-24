using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Data.Sqlite;
using PlaTest.Api.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace PlaTest.Api.Data
{
    public class DataContext : IdentityDbContext<AppUser>
    {
        public DataContext() : base(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString) { }
        public DataContext(string connectionString) : base(connectionString)
        {
        }
    }
}