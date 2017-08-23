using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using System.Threading.Tasks;
using Entities;

namespace DataAccessLayer.Mapping
{
    public class ModelMap: EntityTypeConfiguration<Model>
    {
        public ModelMap()
        {
            HasKey(m => m.ID);

            Property(m => m.Name)
                .HasMaxLength(30)
                .IsRequired();
            Property(m => m.BrandID)
                .IsRequired();
        }
    }
}
