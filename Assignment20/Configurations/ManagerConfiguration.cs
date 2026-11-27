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
    public class ManagerConfiguration : IEntityTypeConfiguration<Manager>
    {
        public void Configure(EntityTypeBuilder<Manager> m)
        {
            m.ToTable("Managers");
            m.HasKey(m => m.Id);
            m.Property(m => m.Id).UseIdentityColumn(202, 2);
            m.Property(m => m.FullName).HasMaxLength(150);
            m.Property(m => m.Email).HasMaxLength(100);
            m.Property(m => m.PhoneNumber).HasMaxLength(30);
            m.HasOne(m => m.ManagedBranch)
                .WithOne(b => b.BranchManager)
                .HasForeignKey<Branch>(b => b.ManagerId)
                .OnDelete(DeleteBehavior.Restrict);

            m.HasData(
                new Manager { Id = 202, FullName = "John Tery", Email = "john.Tery@bank.com", PhoneNumber = "123-456-7890", HireDate = new DateTime(2020, 1, 1)},
                new Manager { Id = 204, FullName = "Reece James", Email = "reece.James@bank.com", PhoneNumber = "098-765-4321", HireDate = new DateTime(2024, 1, 15) }
            );
        }
    }
}
