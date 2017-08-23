using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Mapping
{
    public class CarInfoMap:EntityTypeConfiguration<CarInfo>
    {
        public CarInfoMap()
        {
            HasKey(c => c.CarID);
            Property(c => c.Plate)
                .HasMaxLength(15)
                .IsRequired();
            Property(c => c.DateOfPurchase)
                .IsRequired();
        }
    }
}
