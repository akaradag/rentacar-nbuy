using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAccessLayer.Mapping
{
    public class BillInfoMap: EntityTypeConfiguration<BillInfo>
    {
        public BillInfoMap()
        {
            HasKey(bi => bi.ID);

            Property(bi => bi.FirstName)
                .IsOptional()
                .HasMaxLength(30);

            Property(bi => bi.LastName)
                .IsOptional()
                .HasMaxLength(30);

            Property(bi => bi.CompanyName)
                .IsOptional()
                .HasMaxLength(30);

            Property(bi => bi.TaxOffice)
                .IsOptional()
                .HasMaxLength(30);

            Property(bi => bi.TaxNo)
                .IsOptional();

            Property(bi => bi.Country)
                .IsRequired()
                .HasMaxLength(30);

            Property(bi => bi.Address)
                .IsRequired()
                .HasMaxLength(500);

            HasRequired(bi => bi.Bill)
                .WithOptional(b => b.BillInfo);
        }
    }
}
