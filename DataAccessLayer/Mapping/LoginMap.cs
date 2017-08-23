using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Mapping
{
    class LoginMap : EntityTypeConfiguration<Login>
    {
        public LoginMap()
        {
            HasKey(l => l.CustomerID);

            Property(l => l.UserName)
                .HasMaxLength(20)
                .IsRequired();
            Property(l => l.Password)
                .HasMaxLength(20)
                .IsRequired();
        }
    }
}
