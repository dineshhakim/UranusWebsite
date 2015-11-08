using System.Web.Mvc;
using Uranus.Service.Abstract;

namespace Uranus.Controllers
{
     
    public class ServicesController : Controller
    {
         public readonly IProductService ObjProductService;



         public ServicesController(IProductService objTeamMemberService)
        {
            this.ObjProductService = objTeamMemberService;

        }
        public ActionResult Index()
        {
            var products = ObjProductService.GetAll();
            return View(products);
        }
	}
}