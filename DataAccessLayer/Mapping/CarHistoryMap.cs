using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Mapping
{
    public class CarHistoryMap:EntityTypeConfiguration<CarHistory>
    {
        public CarHistoryMap()
        {
            HasKey(c => c.ID);

            Property(c => c.CustomerID)
                .IsOptional();

            Property(c => c.CarStateID)
                .IsRequired();

            Property(c => c.CarID)
                .IsRequired();

            HasRequired(ch => ch.Car)
                .WithMany(c => c.CarHistories)
                .HasForeignKey(x => x.CarID);
        }
    }
}
