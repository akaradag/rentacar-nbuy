using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Mapping
{
    public class CarMap:EntityTypeConfiguration<Car>
    {
        public CarMap()
        {
            HasKey(c => c.ID);

            Property(c => c.ModelID)
                .IsRequired();
            Property(c => c.Capacity)
                .IsRequired();
            Property(c => c.ColorID)
                .IsRequired();

            Property(c => c.GearID)
                .IsRequired();

            Property(c => c.FuelID)
                .IsRequired();
            Property(c => c.EnginePower)
                .IsRequired();
            Property(c => c.EngineSize)
                .IsRequired();

            HasOptional(c => c.CarInfo)
                .WithRequired(d => d.Car);
        }
    }
}
