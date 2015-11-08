using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Uranus.Domain.Entities;
using Uranus.Service.Abstract;

namespace Uranus.Controllers
{
    [Authorize]
    public class CompanyController : Controller
    {

        public readonly ICompanyService CompanyService;
        public CompanyController(ICompanyService companyService)
        {
            this.CompanyService = companyService;

        }

        //
        // GET: /Company/Details/5
        public ActionResult Details(int id)
        {
            var company = CompanyService.GetById(id);
            return View(company);
        }

        //
        // GET: /Company/Create
        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Index()
        {
            var companys = CompanyService.GetAll();
            return View(companys);
        }
        //
        // POST: /Company/Create
        [HttpPost]
        public ActionResult Create(Company company)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    CompanyService.Add(company);
                    return RedirectToAction("Index");
                }
                return View(company);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Error", ex.Message);
                return View(company);
            }
        }

        //
        // GET: /Company/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Company/Edit/5
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
        // GET: /Company/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Company/Delete/5
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
