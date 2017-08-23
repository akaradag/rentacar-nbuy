using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Mapping
{
    class FuelMap : EntityTypeConfiguration<Fuel>
    {
        public FuelMap()
        {
            Property(f => f.Name)
                .HasMaxLength(30)
                .IsRequired();

            HasMany(f => f.Cars)
                .WithRequired(c => c.Fuel)
                .HasForeignKey(c => c.FuelID);
        }
    }
}
