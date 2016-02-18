using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace ODataInjection.Models
{
    public class User
    {
        public int Id { get; set; }

        public enum UserLevel { FRESHMAN, SOPHOMORE, JUNIOR, SENIOR };
        public UserLevel Level { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public DateTime LastLogin { get; set; }

        [IgnoreDataMember]
        public Guid Token { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }
    }
}