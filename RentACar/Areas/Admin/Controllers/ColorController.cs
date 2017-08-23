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
    public class ColorController : Controller
    {
        ColorBussiness _colorBll;
        public ColorController()
        {
            _colorBll = new ColorBussiness();
        }
        // GET: Admin/Color
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult List()
        {
            List<Color> colorList = new List<Color>();
            try
            {
                colorList = _colorBll.GetAll();
            }
            catch (Exception ex)
            {

            }
            List<ColorVM> colorVMList = new List<ColorVM>();
            foreach (Color item in colorList)
            {
                ColorVM cVM = new ColorVM();
                cVM.ID = item.ID;
                cVM.Name = item.Name;
                colorVMList.Add(cVM);
            }

            return Json(colorVMList, JsonRequestBehavior.AllowGet);
        }

        public JsonResult Add(Color color)
        {

            try
            {

                _colorBll.Add(color);
                return Json("İşlem Başarılı", JsonRequestBehavior.AllowGet);




            }
            catch (Exception)
            {

                return Json("İşlem Başarısız", JsonRequestBehavior.AllowGet);
            }
        }
        public JsonResult GetById(int id)
        {

            try
            {
                Color color = _colorBll.Get(id);
                return Json(color, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {

                return Json(ex, JsonRequestBehavior.AllowGet);
            }


        }


        public JsonResult Update(Color color)
        {
            try
            {
                Color oldColor = _colorBll.Get(color.ID);
                oldColor.Name = color.Name;

                _colorBll.Update(oldColor);
                return Json("İşlem Başarılı", JsonRequestBehavior.AllowGet);

            }
            catch (Exception ex)
            {

                return Json(ex, JsonRequestBehavior.AllowGet);
            }
        }

      
        public JsonResult Delete(int id = 0)
        {
            bool result = false;

            try
            {
                Color color = _colorBll.Get(id);
                result = _colorBll.Remove(color);

                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {

                return Json(ex, JsonRequestBehavior.AllowGet);
            }

        }
    }
}