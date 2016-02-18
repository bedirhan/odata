using ODataInjection.Database;
using ODataInjection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ODataInjection.Repository
{
    public class UserRepository
    {        
        UserContext db;

        public UserRepository()
        {
            db = new UserContext();            
        }

        public IQueryable<User> Get()
        {
            return db.Users;
        }
    }
}