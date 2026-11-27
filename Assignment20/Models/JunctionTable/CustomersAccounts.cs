using Assignment20.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment20.Models.JunctionTable
{
    public class CustomersAccounts
    {
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int AccountId { get; set; }
        public Account Account { get; set; }
        public OwnershipTypeEnum OwnershipType { get; set; }
        public AccountStatusEnum AccountStatus { get; set; }
        public DateTime OwnershipStartDate { get; set; }
    }
}
