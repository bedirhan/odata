using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ODataInjection.Models;

namespace ODataInjection.Database
{
    public class UserContext : DbContext
    {
        public UserContext() : base("UserContext")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<User> Users { get; set; }
    }
}