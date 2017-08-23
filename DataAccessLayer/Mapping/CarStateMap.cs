using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Entities;

namespace DataAccessLayer.Mapping
{
    class CarStateMap : EntityTypeConfiguration<CarState>
    {
        public CarStateMap()
        {
            HasKey(cs => cs.ID);

            Property(cs => cs.Name)
                .HasMaxLength(30)
                .HasColumnType("nvarchar")
                .IsRequired();

            HasMany(cs => cs.CarHistories)
                .WithRequired(ch => ch.CarState)
                .HasForeignKey(ch => ch.CarStateID);
        }
    }
}
