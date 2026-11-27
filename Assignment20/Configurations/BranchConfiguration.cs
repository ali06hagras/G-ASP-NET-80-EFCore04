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
    public class BranchConfiguration : IEntityTypeConfiguration<Branch>
    {
        public void Configure(EntityTypeBuilder<Branch> b)
        {
            b.ToTable("Branches");
            b.HasKey(b => b.Code);
            b.Property(b => b.Code).HasMaxLength(20);
            b.Property(b => b.Name).HasMaxLength(100);
            b.Property(b => b.Address).HasMaxLength(100);
            b.Property(b => b.PhoneNumber).HasMaxLength(30);
            b.HasMany(b => b.Accounts)
                .WithOne(a => a.Branch)
                .HasForeignKey(a => a.BranchId);
        }
    }
}
