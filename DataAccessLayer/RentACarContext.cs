using DataAccessLayer.Mapping;
using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DataAccessLayer
{
   public class RentACarContext:DbContext
    {
       public RentACarContext()
           : base("alfa_neptune_mvc_white_db")
        {
        }
        public virtual DbSet<Bill> Bills { get; set; }
        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<CarHistory> CarHistories { get; set; }
        public virtual DbSet<CarInfo> CarInfos { get; set; }
        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<CarState> CarStates { get; set; }
        public virtual DbSet<Color> Colors { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Fuel> Fuels { get; set; }
        public virtual DbSet<Gear> Gears { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<Model> Models { get; set; }
        public virtual DbSet<PaymentType> PaymentTypes { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<BillInfo> BillInfos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BillMap());
            modelBuilder.Configurations.Add(new BrandMap());
            modelBuilder.Configurations.Add(new CarHistoryMap());
            modelBuilder.Configurations.Add(new CarInfoMap());
            modelBuilder.Configurations.Add(new CarMap());
            modelBuilder.Configurations.Add(new CarStateMap());
            modelBuilder.Configurations.Add(new ColorMap());
            modelBuilder.Configurations.Add(new CustomerMap());
            modelBuilder.Configurations.Add(new FuelMap());
            modelBuilder.Configurations.Add(new GearMap());
            modelBuilder.Configurations.Add(new LoginMap());
            modelBuilder.Configurations.Add(new ModelMap());
            modelBuilder.Configurations.Add(new PaymentTypeMap());
            modelBuilder.Configurations.Add(new RoleMap());
            modelBuilder.Configurations.Add(new BillInfoMap());

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
