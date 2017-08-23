using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.Data.Entity.ModelConfiguration;

namespace DataAccessLayer.Mapping
{
    public class BrandMap:EntityTypeConfiguration<Brand>
    {
        public BrandMap()
        {
            HasKey(b => b.ID);

            Property(b => b.Name)
                .HasMaxLength(30)
                .IsRequired();

        }
    }
}
