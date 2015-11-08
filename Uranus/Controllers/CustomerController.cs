using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Uranus.Domain.Entities;
using Uranus.Service.Abstract;
using Uranus.Utility;

namespace Uranus.Controllers
{
     [Authorize]
    public class CustomerController : Controller
    {
        public readonly ICustomerService CustomerService;

        public CustomerController(ICustomerService customerService)
        {
            this.CustomerService = customerService;
        }

        public ActionResult Index()
        {
            var customers = CustomerService.GetAll();
            return View(customers);
        }

        //
        // GET: /Customer/Details/5
        public ActionResult Details(int id)
        {
            var customer = CustomerService.GetById(id);
            return View(customer);
        }

        //
        // GET: /Customer/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Customer/Create
        [HttpPost]
        public ActionResult Create(Customer customer)
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
                        return View(customer);
                    }
                    customer.ImageUrl = filename;
                    CustomerService.Add(customer);
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(customer);
                }
            }
            catch(Exception ex)
            {
                ModelState.AddModelError("Error", ex.Message);
                return View(customer);
            }
        }

        //
        // GET: /Customer/Edit/5
        public ActionResult Edit(int id)
        {
            var customer = CustomerService.GetById(id);
            return View(customer);
        }

        //
        // POST: /Customer/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Customer customer)
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
                        return View(customer);
                    }
                    customer.ImageUrl = filename;
                    CustomerService.Add(customer);
                    return RedirectToAction("Index");
                }
                return View(customer);
            }
            catch(Exception ex)
            {
                ModelState.AddModelError("Error", ex.Message);
                return View();
            }
        }

        //
        // GET: /Customer/Delete/5
        public ActionResult Delete(int id)
        {
            var customer = CustomerService.GetById(id);
            return View(customer);
        }

        //
        // POST: /Customer/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                var customer = CustomerService.GetById(id);
                CustomerService.Delete(customer);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
