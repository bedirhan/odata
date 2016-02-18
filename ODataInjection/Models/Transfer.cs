using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ODataInjection.Models
{
    public class Transfer
    {
        public int Id { get; set;}
        public DateTime TransferDate { get; set; }
        public Guid ToAccountNumber { get; set; }
        public decimal Amount { get; set; }
        public bool IsSuccess { get; set; }
    }
}
