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
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> c)
        {
            c.ToTable("Customers");
            c.HasKey(c => c.Id);
            c.Property(c => c.Id).UseIdentityColumn(300,3);
            c.Property(c => c.FullName).HasMaxLength(150);
            c.Property(c => c.Email).HasMaxLength(100);
            c.Property(c => c.PhoneNumber).HasMaxLength(30);
            c.Property(c => c.Address).HasMaxLength(100);
            c.Property(c => c.NationalId).HasMaxLength(20);
            c.HasIndex(c => c.NationalId).IsUnique().HasDatabaseName("IX_Customers_NationalId");
            c.Property(c => c.CustomerType).HasConversion<string>().HasMaxLength(50).IsRequired();
        }
    }
}
