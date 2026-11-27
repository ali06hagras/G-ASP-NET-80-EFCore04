using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment20.Models
{
    public class Branch
    {
        public int Code { get; set; } //PK
        public string Name { get; set; } //max 100
        public string Address { get; set; } //max 100
        public string PhoneNumber { get; set; } //max 30
    }
}
