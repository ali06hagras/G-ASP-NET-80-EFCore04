using Assignment20.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment20.Models
{
    public class Transaction
    {
        public int TransactionNumber { get; set; } 
        public DateTime TransactionDate { get; set; } 
        public decimal Amount { get; set; } 
        public TransactionTypeEnum TransactionType { get; set; } 
        public string Note { get; set; } 
        public int AccountId { get; set; }
        public Account Account { get; set; }
    }
}
