using BusinessLayer;
using DataAccessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RentACar.Areas.Admin.Controllers
{
    public class CarController : Controller
    {
        CarBussiness _carBusiness;
        ColorBussiness _colorBusiness;
        ModelBussiness _modelBusiness;
        BrandBussiness _brandBusiness;

        public CarController()
        {
            _carBusiness = new CarBussiness();
            _colorBusiness = new ColorBussiness();
            _modelBusiness = new ModelBussiness();
            _brandBusiness = new BrandBussiness();
        }
        // GET: Admin/Car
        public ActionResult Index()
        {
            List<Color> colorList = new List<Color>();
            colorList = _colorBusiness.GetAll();
            SelectList colorListSelect = new SelectList(colorList, "ID", "Name");
            ViewBag.Color = colorListSelect;



            List<Brand> brandList = new List<Brand>();
            brandList = _brandBusiness.GetAll();
            SelectList brandListSelect = new SelectList(brandList, "ID", "Name");
            ViewBag.Brand = brandListSelect;

            List<Model> modelList = new List<Model>();

            modelList = _modelBusiness.GetAll();
            SelectList modelListSelect = new SelectList(modelList, "ID", "Name");
            ViewBag.Model = modelListSelect;
            return View();
        }

        public JsonResult Add(Car car)
        {



            try
            {
                _carBusiness.Add(car);
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return Json("İşlem başarılı", JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetModels(int id)
        {

            var modelList = (from c in _modelBusiness.GetAll()
                             where c.BrandID == id
                             select new
                             {
                                 Id = c.ID,
                                 Name = c.Name
                             }).ToList();
            //SelectList modelListSelect = new SelectList(modelList, "ID", "Name");
            //ViewBag.Model = modelListSelect;


            return Json(modelList, JsonRequestBehavior.AllowGet);
        }

    }
}