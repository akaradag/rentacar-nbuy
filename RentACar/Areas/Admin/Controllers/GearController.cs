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
    public class GearController : Controller
    {
        private GearBussiness _gearBll;

        public GearController()
        {
            _gearBll = new GearBussiness();
        }
        // GET: Admin/Gear
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult List()
        {
            List<Gear> gearList = new List<Gear>();
            try
            {
                 gearList = _gearBll.GetAll();

                
            }
            catch (Exception ex)
            {

                return Json(ex, JsonRequestBehavior.AllowGet);
            }
            List<GearVM> gearVmList = new List<GearVM>();
            foreach (var item in gearList)
            {
                GearVM gearVm = new GearVM();
                gearVm.ID = item.ID;
                gearVm.Name = item.Name;
                gearVmList.Add(gearVm);
            }
            return Json(gearVmList,JsonRequestBehavior.AllowGet);
        }

        public JsonResult Add(Gear gear)
        {

            try
            {
            
                    _gearBll.Add(gear);
                    return Json("İşlem Başarılı", JsonRequestBehavior.AllowGet);
               
               
                    
               
            }
            catch (Exception )
            {

                return Json("İşlem Başarısız", JsonRequestBehavior.AllowGet);
            }
        }
        public JsonResult GetById(int id)
        {
           
                try
                {
                   Gear gear= _gearBll.Get(id);
                    return Json(gear, JsonRequestBehavior.AllowGet);
                }
                catch (Exception ex)
                {

                    return Json(ex, JsonRequestBehavior.AllowGet);
                }
           
           
        }
        
        
        public JsonResult Update(Gear gear)
        {
            try
            {
               Gear oldGear= _gearBll.Get(gear.ID);
                oldGear.Name = gear.Name;

                _gearBll.Update(oldGear);
                return Json("İşlem Başarılı", JsonRequestBehavior.AllowGet);

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
                Gear stu = _gearBll.Get(id);
                result = _gearBll.Remove(stu);

                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {

                return Json(ex, JsonRequestBehavior.AllowGet);
            }

        }
    }
}
