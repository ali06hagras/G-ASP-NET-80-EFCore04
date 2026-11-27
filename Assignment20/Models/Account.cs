using Assignment20.Enums;
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
    }
}
