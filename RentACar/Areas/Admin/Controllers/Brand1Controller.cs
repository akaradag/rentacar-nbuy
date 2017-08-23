using BusinessLayer;
using Entities;
using RentACar.Areas.Admin.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RentACar.Areas.Admin.Controllers
{
    public class Brand1Controller : Controller
    {
        BrandBussiness _brandBll;
        public Brand1Controller()
        {
            _brandBll = new BrandBussiness();
        }
        // GET: Admin/Brand1
        
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult Add(Brand Brand)
        {

            try
            {

                _brandBll.Add(Brand);

                return Json("İşlem başarılı", JsonRequestBehavior.AllowGet);
            }
            catch (Exception)
            {

                return Json("İşlem başarısız", JsonRequestBehavior.AllowGet);
            }
           
           
            
        }
        
        public JsonResult List()
        {
            List<Brand> brandList = new List<Brand>();
            try
            {
                brandList = _brandBll.GetAll();
            }
            catch (Exception ex)
            {

                return Json(ex, JsonRequestBehavior.AllowGet);
            }
                
                
            
           
            List<BrandVM> brandVMList = new List<BrandVM>();
            foreach (var item in brandList)
            {
                BrandVM brandVm = new BrandVM();
                brandVm.ID = item.ID;
                brandVm.Name = item.Name;
                brandVMList.Add(brandVm);
            }
            return Json(brandVMList, JsonRequestBehavior.AllowGet);


        }
        public JsonResult GetById(int id)
        {
            try
            {
                Brand Brands = _brandBll.Get(id);
                return Json(Brands, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {

                return Json(ex, JsonRequestBehavior.AllowGet);
            }


        }
        [HttpPost]
        public JsonResult Update(Brand Brand)
        {
            bool result;
            Brand oldBrands = _brandBll.Get(Brand.ID);
            oldBrands.Name = Brand.Name;
            try
            {
                result = _brandBll.Update(oldBrands);
                return Json(new { msg = result }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {

                return Json(ex, JsonRequestBehavior.AllowGet);
            }

        }
        [HttpPost]
        public JsonResult Delete(int id = 0)
        {
            bool result = false;

            try
            {
                Brand brand = _brandBll.Get(id);
                result = _brandBll.Remove(brand);

                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {

                return Json(ex, JsonRequestBehavior.AllowGet);
            }

        }
    }
}