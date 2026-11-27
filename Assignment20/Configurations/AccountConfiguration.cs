using Assignment20.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment20.Configurations
{
    public class AccountConfiguration : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> a)
        {
            a.ToTable("Accounts");
            a.HasKey(a => a.AccountNumber);
            a.Property(a => a.AccountNumber).UseIdentityColumn(1000,5);
            a.Property(a => a.CurrentBalance).HasPrecision(18, 2);
            a.Property(a => a.AccountType).HasConversion<string>().HasMaxLength(50).IsRequired();
            a.Property(a => a.OpeningDate).HasDefaultValueSql("GETDATE()");
        }
    }
}
