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
        public int AccountNumber { get; set; } 
        public decimal CurrentBalance { get; set; } 
        public AccountTypeEnum AccountType { get; set; } 
        public DateTime OpeningDate { get; set; } 
        public string BranchCode { get; set; }
        public Branch Branch { get; set; }
        public ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
        public ICollection<CustomersAccounts> Customers { get; set; } = new List<CustomersAccounts>();
    }
}
