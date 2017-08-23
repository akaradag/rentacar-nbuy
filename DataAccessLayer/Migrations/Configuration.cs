namespace DataAccessLayer.Migrations
{
    using Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DataAccessLayer.RentACarContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(DataAccessLayer.RentACarContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            //Role role = new Role();
            //role.Name = "Admin";
            //context.Roles.AddOrUpdate(role);

            //Role role1 = new Role();
            //role1.Name = "Müþteri";
            //context.Roles.AddOrUpdate(role1);

            //Color color = new Color();
            //color.Name = "Sarý";
            //context.Colors.AddOrUpdate(color);

            //Color color1 = new Color();
            //color1.Name = "Kýrmýzý";
            //context.Colors.AddOrUpdate(color1);

            //Customer customer = new Customer();
            //customer.FirstName = "Zeynep";
            //customer.LastName = "Asman";
            //customer.Phone = "5555555";
            //customer.RoleID = 1;
            //customer.Address = "Bakýrköy Bilge Adam";
            //customer.Email = "zeynep.asman@bilgeadam.com";
            //customer.DateOfBirth = DateTime.Parse("1992-12-2");
            //Login login = new Login();
            //login.UserName = "zey";
            //login.Password = "123";
            //customer.Login = login;
            //context.Customers.Add(customer);

            //Fuel fuel = new Fuel();
            //fuel.Name = "Benzin";
            //context.Fuels.Add(fuel);

            //Fuel fuel1 = new Fuel();
            //fuel1.Name = "Dizel";
            //context.Fuels.Add(fuel1);

            //Gear gear = new Gear();
            //gear.Name = "Otomatik";
            //context.Gears.Add(gear);

            //Gear gear1 = new Gear();
            //gear1.Name = "Manuel";
            //context.Gears.Add(gear1);

            //Brand brand = new Brand();
            //brand.Name = "Opel";
            //context.Brands.AddOrUpdate(brand);

            //Model model = new Model();
            //model.Name = "Astra";
            //model.BrandID = 3;

            // context.Models.AddOrUpdate(m=>m.ID,model);

            //Car car = new Car();
            //car.ModelID = 1;
            //car.RentPrice = 125;
            //car.GearID = 1;
            //car.FuelID = 1;
            //car.ColorID = 3;
            //car.Capacity = 5;
            //car.EnginePower = 150;
            //car.EngineSize = 100;
            //CarInfo carInfo = new CarInfo();
            //carInfo.DateOfPurchase = DateTime.Parse("2015-12-5");
            //carInfo.Weight = 210;
            //carInfo.Plate = "34 DAZ 34";
            //car.CarInfo = carInfo;
            //context.Cars.Add(car);

            //Car car1 = new Car();
            //car1.ModelID = 1;
            //car1.RentPrice = 200;
            //car1.GearID = 2;
            //car1.FuelID = 2;
            //car1.ColorID = 4;
            //car1.Capacity = 4;
            //car1.EnginePower = 150;
            //car1.EngineSize = 100;
            //CarInfo carInfo1 = new CarInfo();
            //carInfo1.DateOfPurchase = DateTime.Parse("2015-5-5");
            //carInfo1.Weight = 250;
            //carInfo1.Plate = "34 KAR 47";
            //car1.CarInfo = carInfo1;
            //car1.PictureURL = "http://cdn.mercedes-benz.com.tr/files/slides/a-serisi/125-270-15-2939-A-Serisi_1.jpg";
            //context.Cars.Add(car1);

            //CarState carState = new CarState();
            //carState.Name = "Arýzalý";
            //context.CarStates.Add(carState);


            //CarState carState1 = new CarState();
            //carState1.Name = "Saðlam";
            //context.CarStates.Add(carState1);

            //CarState carState2 = new CarState();
            //carState2.Name = "Kirada";
            //context.CarStates.Add(carState2);

            //CarState carState3 = new CarState();
            //carState3.Name = "Rezerve";
            //context.CarStates.Add(carState3);

        }
    }
}
