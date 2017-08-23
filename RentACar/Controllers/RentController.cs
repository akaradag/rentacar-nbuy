using BusinessLayer;
using Entities;
using RentACar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RentACar.Controllers
{
    public class RentController : Controller
    {
        CarBussiness _carBusiness;
        CustomerBussiness _custBussiness;

        public RentController()
        {
            _carBusiness = new CarBussiness();
            _custBussiness = new CustomerBussiness();
        }
        // GET: Rent
        public ActionResult Index(RentVM rentInfo)
        {
            Car car = new Car();
            try
            {
                car = _carBusiness.Get(rentInfo.CarId);
            }
            catch (Exception ex)
            {

            }
            double rentDays = (rentInfo.EndDate - rentInfo.StartDate).TotalDays;
            decimal totalPrice = car.RentPrice * Convert.ToDecimal(rentDays);

            rentInfo.RentDayCount = rentDays;
            rentInfo.TotalPrice = totalPrice;

            return View(rentInfo);
        }
        [HttpPost]
        public JsonResult RentConfirmed(BillInfoVM billInfoVM)
        {
            CarHistory carHist = new CarHistory();
            carHist.StartingDate = Convert.ToDateTime(Session["StartDate"]);
            carHist.EndingDate = Convert.ToDateTime(Session["EndDate"]);
            carHist.TransactionDate = DateTime.Today;
            carHist.CarID = billInfoVM.CarId;
            carHist.CarStateID = 3;  // Rezervasyon durumu: Kirada

            if (Session["LoginId"] != null)
            {
                carHist.CustomerID = billInfoVM.CustomerId;
            }
            else
            {
                Customer customer = new Customer();
                var names = billInfoVM.CustomerName.Split(' ');
                customer.FirstName = names[0];
                customer.LastName = names[1];
                customer.Address = billInfoVM.CustomerAddress;
                customer.DateOfBirth = billInfoVM.CustomerBirth;
                customer.Email = billInfoVM.CustomerMail;
                customer.Phone = billInfoVM.CustomerPhone;
                customer.SocialNumber = billInfoVM.CustomerSocialNum;
                customer.RoleID = 2;

                carHist.Customer = customer;
            }

            BillInfo billInfo = new BillInfo();
            if (billInfoVM.IsPersonalBill)
            {
                billInfo.FirstName = billInfoVM.BillFirstName;
                billInfo.LastName = billInfoVM.BillLastName;
                billInfo.Address = billInfoVM.BillAddress;
                billInfo.Country = billInfoVM.BillCountry;
            }
            else
            {
                billInfo.CompanyName = billInfoVM.BillCompanyName;
                billInfo.Address = billInfoVM.BillCompanyAddress;
                billInfo.Country = billInfoVM.BillCompanyCountry;
                billInfo.TaxNo = billInfoVM.BillTaxNo;
                billInfo.TaxOffice = billInfoVM.BillTaxOffice;
            }

            Bill bill = new Bill();
            bill.Date = DateTime.Today;
            bill.PaymentTypeID = 1;  // Ödeme Tipi: Kredi Kartı
            bill.Price = billInfoVM.TotalPrice;

            bill.BillInfo = billInfo;
            carHist.Bills.Add(bill);

            CarHistoryBussiness _carHistoryBll = new CarHistoryBussiness();
            string result;
            try
            {
                _carHistoryBll.Add(carHist);
                result = "İşleminiz başarıyla tamamlanmıştır.";
            }
            catch (Exception ex)
            {
                result = string.Format("İşleminiz başarısız. {0}", ex.Message);
            }
                return Json(result);
        }
    }
}