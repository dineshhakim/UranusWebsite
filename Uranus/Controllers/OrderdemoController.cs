using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Uranus.Domain.Entities;
using Uranus.Service.Abstract;

namespace Uranus.Controllers
{
    public class OrderdemoController : Controller
    {
        public readonly IOrderDemoService ObjOrderDemoService;

        public OrderdemoController(IOrderDemoService objOrderDemoService)
        {
            ObjOrderDemoService = objOrderDemoService;
        }
        //
        // GET: /Orderdemo/
        public ActionResult Index()
        {
            return View();
        }



        [HttpPost]
        public ActionResult Index(OrderDemo model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ObjOrderDemoService.Add(model);
                    TempData["Message"] = "Thankyou for your information. We will contact you soon..!!";


                }
                else
                {
                    return View(model);
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
         [Authorize]
        public ActionResult List()
        {
            var lstOrderList = ObjOrderDemoService.GetAll();
            return View(lstOrderList);
        }
         [Authorize]
        public ActionResult Details(int id)
        {
            var lstOrderList = ObjOrderDemoService.GetById(id);
            return View(lstOrderList);
        }
    }
}
