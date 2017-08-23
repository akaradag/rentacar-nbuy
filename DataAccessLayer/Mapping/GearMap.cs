using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Mapping
{
    class GearMap : EntityTypeConfiguration<Gear>
    {
        public GearMap()
        {
            Property(g => g.Name)
                .HasMaxLength(30)
                .IsRequired();

            HasMany(g => g.Cars)
                .WithRequired(c => c.Gear)
                .HasForeignKey(c => c.GearID);
        }
    }
}
