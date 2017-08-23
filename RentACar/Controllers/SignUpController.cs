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
    public class SignUpController : Controller
    {
        LoginBussiness _loginBussiness;
        CustomerBussiness _customerBussiness;
        // GET: SignUp
        public SignUpController()
        {
            _loginBussiness = new LoginBussiness();
            _customerBussiness = new CustomerBussiness();
        }
        public ActionResult Index()
        {

            return View();
        }
       
        public JsonResult Add(Customer customer,Login login)
        {
            customer.RoleID = 2; 
            _customerBussiness.Add(customer);

            int customerID = _customerBussiness.GetCustomerId(customer.FirstName, customer.LastName);
            login.CustomerID = customerID;
            _loginBussiness.Add(login);

            return Json("İşlem başarılı", JsonRequestBehavior.AllowGet);

            
        }

    }
}