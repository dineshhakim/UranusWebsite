using System.Web.Mvc;
using Uranus.Domain.Entities;
using Uranus.Service.Abstract;

namespace Uranus.Controllers
{
    public class ContactController : Controller
    {

        public readonly IContactUsService ObjContactUsService;



        public ContactController(IContactUsService objContactUsService)
        {
            this.ObjContactUsService = objContactUsService;

        }
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(ContactUs contactUs)
        {
            if (ModelState.IsValid)
            {
                ObjContactUsService.Add(contactUs);

                //  ModelState("ImageUpload Error", filename);
            }
            else
            {
                return View(contactUs);
            }
            TempData["Message"] = "Thankyou for your information. We will contact you soon";

            return RedirectToAction("Index");
        }

        public ActionResult List()
        {
            var lstContact = ObjContactUsService.GetAll();
            return View(lstContact);
        }
        public ActionResult Details(int id)
        {
            var lstContactList = ObjContactUsService.GetById(id);
            return View(lstContactList);
        }
    }
}