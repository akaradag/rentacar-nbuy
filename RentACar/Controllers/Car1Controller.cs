using BusinessLayer;
using Entities;
using RentACar.Filters;
using RentACar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RentACar.Controllers
{
    public class Car1Controller : Controller
    {
        CarBussiness cBuss;
        public Car1Controller()
        {
            cBuss = new CarBussiness();
        }
        // GET: Car1
        public ActionResult CarSelect(RentDatesVM dates)
        {
            Session["StartDate"] = dates.StartingDate;
            Session["EndDate"] = dates.EndingDate;

            List<Car> cars = new List<Car>();
            try
            {
                cars = cBuss.GetByDate(DateTime.Parse(dates.StartingDate), DateTime.Parse(dates.EndingDate));
            }
            catch (Exception ex)
            {

            }

            List<CarWithInfoVM> carVMs = new List<CarWithInfoVM>();

            foreach (Car item in cars)
            {
                CarWithInfoVM carVM = new CarWithInfoVM();
                carVM.ID = item.ID;
                carVM.Brand = item.Model.Brand.Name;
                carVM.Capacity = item.Capacity;
                carVM.Color = item.Color.Name;
                carVM.EnginePower = item.EnginePower;
                carVM.EngineSize = item.EngineSize;
                carVM.Fuel = item.Fuel.Name;
                carVM.Gear = item.Gear.Name;
                carVM.Model = item.Model.Name;
                carVM.Picture = item.PictureURL;
                carVM.RentPrice = item.RentPrice;

                carVMs.Add(carVM);
            }

            return View(carVMs);
        }
        [HttpPost][LoginRequiredAttribute]
        public ActionResult CarSelect(int ID)
        {
            RentVM rent = new RentVM();
            rent.CarId =ID;
            rent.CustomerId = (int)Session["LoginId"];
            rent.StartDate = Convert.ToDateTime(Session["StartDate"]);
            rent.EndDate = Convert.ToDateTime(Session["EndDate"]);

            return RedirectToAction("Index", "Rent", rent);
        }
    }
}