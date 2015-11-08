using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Uranus.Service.Abstract;

namespace Uranus.Controllers
{
    public class FeaturesController : Controller
    {

        public readonly IFeaturesService ObjService;
        public FeaturesController(IFeaturesService objService)
        {
            this.ObjService = objService;
        }
        //
        // GET: /Features/
        public ActionResult Index()
        {
            var features = ObjService.GetAll();
            return View(features);
        }

        //
        // GET: /Features/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Features/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Features/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Features/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Features/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Features/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Features/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
