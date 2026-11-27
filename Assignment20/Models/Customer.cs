using Assignment20.Enums;
using Assignment20.Models.JunctionTable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment20.Models
{
    public class Customer
    {
        public int Id { get; set; } 
        public string FullName { get; set; } 
        public string Email { get; set; } 
        public string PhoneNumber { get; set; } 
        public string Address { get; set; } 
        public string NationalId { get; set; } 
        public DateTime DateOfBirth { get; set; }
        public CustomerTypeEnum CustomerType { get; set; } 
        public ICollection<CustomersAccounts> Accounts { get; set; } = new List<CustomersAccounts>();
    }
}
