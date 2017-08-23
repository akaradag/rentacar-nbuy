using BusinessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RentACar.Controllers
{
    public class LoginController : Controller
    {
        LoginBussiness _loginBussiness;
        CustomerBussiness _customerBussiness;
        public LoginController()
        {
            _customerBussiness = new CustomerBussiness();
            _loginBussiness = new LoginBussiness();
        }
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string username, string password)
        {
           Login _login= _loginBussiness.GetLogin(username, password);
            if (_login != null)
            {
                Session["LoginId"] = _login.CustomerID;
                Session["UserName"] = _login.UserName;
                Customer customer = _customerBussiness.Get(_login.CustomerID);
                Session["CustomerName"] = customer.FirstName;
                Session["CustomerLastName"] = customer.LastName;
                if (customer.RoleID == 1)
                {
                    return RedirectToAction("Index", "Home", new { area = "Admin" });
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            else
            {
                ViewBag.Message = "Kullanıcı adı ya da parolanız hatalı";
                return View();
            }
           
            
        }
        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Index", "Home");
        }


    }
}