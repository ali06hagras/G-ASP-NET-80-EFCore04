using Assignment20.Enums;
using Assignment20.Models.JunctionTable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment20.Models
{
    public class Account
    {
        public int AccountNumber { get; set; } //pk
        public decimal CurrentBalance { get; set; } //(18,2)
        public AccountTypeEnum AccountType { get; set; } // convert to string
        public DateTime OpeningDate { get; set; } // GetDate()
        public int BranchId { get; set; }
        public Branch Branch { get; set; }
        public ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
        public ICollection<CustomersAccounts> Customers { get; set; } = new List<CustomersAccounts>();
    }
}
