using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment20.Models
{
    public class Branch
    {
        public string Code { get; set; } //PK max 20
        public string Name { get; set; } //max 100
        public string Address { get; set; } //max 100
        public string PhoneNumber { get; set; } //max 30
        public int ManagerId { get; set; }
        public Manager BranchManager { get; set; }
        public ICollection<Account> Accounts { get; set; } = new List<Account>();
    }
}
