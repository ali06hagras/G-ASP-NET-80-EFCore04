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
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> t)
        {
            t.ToTable("Transactions");
            t.HasKey(t => t.TransactionNumber);
            t.Property(t => t.TransactionNumber).UseIdentityColumn(4000, 8);
            t.Property(t => t.Amount).HasPrecision(18, 2);
            t.Property(t => t.TransactionType).HasConversion<string>().HasMaxLength(50).IsRequired();
            t.Property(t => t.TransactionDate).HasDefaultValueSql("GETDATE()");
            t.Property(t => t.Note).HasMaxLength(200);
            t.HasOne(t => t.Account)
                .WithMany(a => a.Transactions)
                .HasForeignKey(t => t.AccountId);
        }
    }
}
