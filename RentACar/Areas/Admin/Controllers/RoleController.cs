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
    public class RoleController : Controller
    {
        RoleBussiness _rb;

        public RoleController()
        {
            _rb = new RoleBussiness();
        }
        // GET: Admin/Role
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult Add(Role Role)
        {
           
            if (Role != null)
            {
                _rb.Add(Role);

                return Json("İşlem başarılı", JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json("İşlem başarısız", JsonRequestBehavior.AllowGet);
            }
        }
        public JsonResult List()
        {
            List<Role> roleList = new List<Role>();
            try
            {
                 roleList = _rb.GetAll();
               
            }
            catch (Exception ex)
            {
                return Json(ex, JsonRequestBehavior.AllowGet);
            }
            List<RoleVM> roleVMList = new List<RoleVM>();
            foreach (var item in roleList)
            {
                RoleVM roleVm = new RoleVM();
                roleVm.Id = item.Id;
                roleVm.Name = item.Name;
                roleVMList.Add(roleVm);
            }
            return Json(roleVMList, JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetById(int id)
        {
            try
            {
                Role Roles = _rb.Get(id);
                return Json(Roles, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {

                return Json(ex, JsonRequestBehavior.AllowGet);
            }


        }
        [HttpPost]
        public JsonResult Update(Role Role)
        {
            bool result;
            Role oldRoles = _rb.Get(Role.Id);
            oldRoles.Name = Role.Name;
            try
            {
                result = _rb.Update(oldRoles);
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
            bool result=false;
          
                try
                {
                    Role stu = _rb.Get(id);
                    result = _rb.Remove(stu);

                    return Json(result, JsonRequestBehavior.AllowGet);
                }
                catch (Exception ex)
                {

                    return Json(ex, JsonRequestBehavior.AllowGet);
                }
           
        }
    }
}