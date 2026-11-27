using Assignment20.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment20.Models
{
    public class Customer
    {
        public int Id { get; set; } //pk
        public string FullName { get; set; } //max 150
        public string Email { get; set; } //max 100
        public string PhoneNumber { get; set; } //max 30
        public string Address { get; set; } //max 100
        public string NationalId { get; set; } //max 20 Unique
        public DateTime DateOfBirth { get; set; }
        public CustomerTypeEnum CustomerType { get; set; } // convert to string
    }
}
