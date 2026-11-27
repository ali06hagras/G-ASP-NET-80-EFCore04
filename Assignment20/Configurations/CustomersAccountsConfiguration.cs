using Assignment20.Models;
using Assignment20.Models.JunctionTable;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment20.Configurations
{
    public class CustomersAccountsConfiguration : IEntityTypeConfiguration<CustomersAccounts>
    {
        public void Configure(EntityTypeBuilder<CustomersAccounts> ca)
        {
            ca.HasKey(ca => new { ca.CustomerId, ca.AccountId });
            ca.Property(ca => ca.OwnershipType).HasConversion<string>().HasMaxLength(50).IsRequired();
            ca.Property(ca => ca.AccountStatus).HasConversion<string>().HasMaxLength(50).IsRequired();
            ca.Property(ca => ca.OwnershipStartDate).HasDefaultValueSql("GETDATE()").IsRequired();
            ca.HasOne(ca => ca.Customer)
                .WithMany(c => c.Accounts)
                .HasForeignKey(ca => ca.CustomerId);
            ca.HasOne(ca => ca.Account)
                .WithMany(a => a.Customers)
                .HasForeignKey(ca => ca.AccountId);
        }
    }
}
