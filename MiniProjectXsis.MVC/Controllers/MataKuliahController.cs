using MiniProject.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewModel;

namespace MiniProjectXsis.MVC.Controllers
{
    public class MataKuliahController : Controller
    {
        //
        // GET: /MataKuliah/
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult List()
        {
            return PartialView("_List", MataKuliahRepo.All());
        }

        public ActionResult Create()
        {
            return PartialView("_Create");
        }

        [HttpPost]
        public ActionResult Create(MataKuliahViewModel model)
        {

            if (ModelState.IsValid)
            {
                if (MataKuliahRepo.Update(model))
                {
                    return Json(new { success = true }, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    return Json(new { success = false, message = MataKuliahRepo.Message }, JsonRequestBehavior.AllowGet);
                }
            }
            ModelState.AddModelError("", "Invalid Model State");
            return PartialView("_Create", model);

        }
        public ActionResult Edit(int id)
        {
            MataKuliahViewModel model = MataKuliahRepo.GetById(id);
            return PartialView("_Edit", model);
        }

        [HttpPost]
        public ActionResult Edit(MataKuliahViewModel model)
        {
            MataKuliahRepo.Update(model);
            return Json(new { success = true, message = "Success" }, JsonRequestBehavior.AllowGet);

        }


        public ActionResult Delete(int id)
        {
            if (Request.HttpMethod == "GET")
            {
                MataKuliahViewModel model = MataKuliahRepo.GetById(id);
                return PartialView("_Delete", model);
            }
            else
            {
                MataKuliahRepo.Delete(id);
                return Json(new { success = true, message = "Success" }, JsonRequestBehavior.AllowGet);
            }
        }
	}
}