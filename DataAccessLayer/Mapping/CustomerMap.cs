using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Mapping
{
    class CustomerMap : EntityTypeConfiguration<Customer>
    {
        public CustomerMap()
        {
            HasKey(cu => cu.ID);

            Property(cu => cu.Address)
                .HasMaxLength(500)
                .IsRequired();
            Property(cu => cu.Email)
                .HasMaxLength(100)
                .IsRequired();
            Property(cu => cu.FirstName)
                .HasMaxLength(50)
                .IsRequired();
            Property(cu => cu.LastName)
                .HasMaxLength(50)
                .IsRequired();
            Property(cu => cu.Phone)
                .HasMaxLength(20)
                .IsRequired();

            HasRequired(cu => cu.Role)
                .WithMany(r => r.Customers)
                .HasForeignKey(cu => cu.RoleID);
            HasMany(cu => cu.CarHistories)
                .WithOptional(ch => ch.Customer)
                .HasForeignKey(ch => ch.CustomerID);
            HasOptional(cu => cu.Login)
                .WithRequired(l => l.Customer);

        }
    }
}
