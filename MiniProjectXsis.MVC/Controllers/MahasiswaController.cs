using MiniProject.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewModel;

namespace MiniProjectXsis.MVC.Controllers
{
    public class MahasiswaController : Controller
    {
        //
        // GET: /Mahasiswa/
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult List()
        {
            return PartialView("_List", MahasiswaRepo.All());
        }

        public ActionResult Create()
        {
            ViewBag.ProdiList = new SelectList(MahasiswaRepo.Alls(), "Kode_Prodi", "Nama_Prodi");
            return PartialView("_Create");
        }

        [HttpPost]
        public ActionResult Create(MahasiswaViewModel model)
        {

            if (ModelState.IsValid)
            {
                if (MahasiswaRepo.Update(model))
                {
                    return Json(new { success = true }, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    return Json(new { success = false, message = MahasiswaRepo.Message }, JsonRequestBehavior.AllowGet);
                }
            }
            ModelState.AddModelError("", "Invalid Model State");
            return PartialView("_Create", model);

        }
        public ActionResult Edit(int id)
        {
            ViewBag.ProdiList = new SelectList(MahasiswaRepo.Alls(), "Kode_Prodi", "Nama_Prodi");
            MahasiswaViewModel model = MahasiswaRepo.GetById(id);
            return PartialView("_Edit", model);
        }

        [HttpPost]
        public ActionResult Edit(MahasiswaViewModel model)
        {
            MahasiswaRepo.Update(model);
            return Json(new { success = true, message = "Success" }, JsonRequestBehavior.AllowGet);

        }


        public ActionResult Delete(int id)
        {
            if (Request.HttpMethod == "GET")
            {
                MahasiswaViewModel model = MahasiswaRepo.GetById(id);
                return PartialView("_Delete", model);
            }
            else
            {
                MahasiswaRepo.Delete(id);
                return Json(new { success = true, message = "Success" }, JsonRequestBehavior.AllowGet);
            }
        }
	}
}