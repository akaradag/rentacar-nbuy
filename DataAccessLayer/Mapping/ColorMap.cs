using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Mapping
{
    class ColorMap : EntityTypeConfiguration<Color>
    {
        public ColorMap()
        {
            HasKey(co => co.ID);

            Property(co => co.Name)
                .HasMaxLength(30)
                .IsRequired();

            HasMany(co => co.Cars)
                .WithRequired(c => c.Color)
                .HasForeignKey(c => c.ColorID);
        }
    }
}
