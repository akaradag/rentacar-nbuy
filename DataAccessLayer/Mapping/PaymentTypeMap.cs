using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Mapping
{
    class PaymentTypeMap : EntityTypeConfiguration<PaymentType>
    {
        public PaymentTypeMap()
        {
            HasKey(pt => pt.ID);

            Property(pt => pt.Name)
                .HasMaxLength(50)
                .IsRequired();

            HasMany(pt => pt.Bills)
                .WithRequired(b => b.PaymentType)
                .HasForeignKey(b => b.PaymentTypeID);
        }
    }
}
