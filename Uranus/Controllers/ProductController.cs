using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Uranus.Domain.Entities;
using Uranus.Service.Abstract;
using Uranus.Service.Implementation;
using Uranus.Utility;

namespace Uranus.Controllers
{
    [Authorize]
    public class ProductController : Controller
    {
        public readonly IProductService ObjProductService;



        public ProductController(IProductService objTeamMemberService)
        {
            this.ObjProductService = objTeamMemberService;

        }
        //
        // GET: /Product/
        public ActionResult Index()
        {
            var products = ObjProductService.GetAll();
            return View(products);
        }

        //
        // GET: /Product/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Product/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Product/Create
        [HttpPost]
        public ActionResult Create(Products model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var obj = new FileUploadHelper();
                    var filename = obj.SaveImages();
                    if (filename == obj.ErrorMessage)
                    {
                        ModelState.AddModelError("ImageUpload Error", filename);
                        return View(model);
                    }
                    model.ImageUrl = filename;
                    ObjProductService.Add(model);
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(model);
                }
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Product/Edit/5
        public ActionResult Edit(int id)
        {
            var product = ObjProductService.GetById(id);
            return View(product);
        }

        //
        // POST: /Product/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Products product)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ObjProductService.Update(product);
                    return RedirectToAction("Index");
                }
                return View(product);
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Product/Delete/5
        public ActionResult Delete(int id)
        {
            var product = ObjProductService.GetById(id);
            return View(product);
        }

        //
        // POST: /Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                var product = ObjProductService.GetById(id);
                ObjProductService.Delete(product);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
