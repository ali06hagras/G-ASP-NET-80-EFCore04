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
        public int TransactionNumber { get; set; } //pk with ideas
        public DateTime TransactionDate { get; set; } //GetDate()
        public decimal Amount { get; set; } //(18,2)
        public TransactionTypeEnum TransactionType { get; set; } // convert to string
        public string Note { get; set; } //max 200
    }
}
