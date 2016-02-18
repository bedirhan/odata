using ODataInjection.Models;
using ODataInjection.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.OData;

namespace ODataInjection.Controllers
{
    public class UserController : ApiController
    {
        UserRepository repository = new UserRepository();

        [EnableQuery]
        public IQueryable<User> Get()
        {
            return repository.Get();
        }
    }

    /*
     Security Guidance
     http://www.asp.net/web-api/overview/odata-support-in-aspnet-web-api/odata-security-guidance
     
     This is OData v4. The syntax is different than OData v3          
     http://localhost:49910/api/user
     http://localhost:49910/api/user?$expand=Accounts
     http://localhost:49910/api/user?$expand=Accounts%28$expand=Transfers%29 --> ODATA v4
     http://localhost:49910/api/user?$filter=startswith%28Token,%27a%27%29 -> FAILS     
     */
}