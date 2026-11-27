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
            b.Property(b => b.Code).HasMaxLength(20).IsRequired();
            b.Property(b => b.Name).HasMaxLength(100).IsRequired();
            b.Property(b => b.Address).HasMaxLength(100);
            b.Property(b => b.PhoneNumber).HasMaxLength(30);
            b.HasMany(b => b.Accounts)
                .WithOne(a => a.Branch)
                .HasForeignKey(a => a.BranchCode)
                .OnDelete(DeleteBehavior.Restrict);

            b.HasData(
                new Branch { Code = "CAI-01", Name = "Cairo Main Branch", Address = "12 Talaat Harb Street, Downtown", PhoneNumber = "02-2392-4815", ManagerId = 202 },
                new Branch { Code = "ALX-01", Name = "Alexandria Branch", Address = "26 El-Horreya Road, Azarita", PhoneNumber = "03-486-7291", ManagerId = 204 }
            );
        }
    }
}
