using BusinessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RentACar.Areas.Admin.Controllers
{
    public class ModelController : Controller
    {
        ModelBussiness _modelbusiness;
        BrandBussiness _brandbussiness;
        public ModelController()
        {
            _modelbusiness = new ModelBussiness();
            _brandbussiness = new BrandBussiness();
        }
        // GET: Admin/Model
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult Add(Model model)
        {
            try
            {
                List<Brand> brands = _brandbussiness.GetAll();
                SelectList brandList = new SelectList(brands, "ID", "Name");
                ViewBag.List = brandList;
                _modelbusiness.Add(model);
                return Json("İşlem başarılı",JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}