using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ODataInjection.Models
{
    public class Account
    {
        public int Id { get; set; }

        public enum AccountType { MAIN, SAVINGS, CREDIT };
        public AccountType Type { get; set; }

        public decimal Balance { get; set; }
        public DateTime CreateDate { get; set; }

        public Guid AccountNumber { get; set; }

        public virtual ICollection<Transfer> Transfers { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
