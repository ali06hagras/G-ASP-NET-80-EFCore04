using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment20.Models
{
    public class Manager
    {
        public int Id { get; set; } //pk
        public string FullName { get; set; } //max 150
        public string Email { get; set; } //max 100
        public string PhoneNumber { get; set; } //max 30
        public DateTime HireDate { get; set; }
    }
}
