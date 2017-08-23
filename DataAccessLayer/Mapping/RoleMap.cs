using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Mapping
{
    class RoleMap : EntityTypeConfiguration<Role>
    {
        public RoleMap()
        {
            HasKey(r => r.Id);

            Property(r => r.Name)
                .HasMaxLength(30)
                .IsRequired();

            HasMany(r => r.Customers)
                .WithRequired(cu => cu.Role)
                .HasForeignKey(cu => cu.RoleID);
        }
    }
}
