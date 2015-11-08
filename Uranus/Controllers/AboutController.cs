using System.Web.Mvc;
using Uranus.Models;
using Uranus.Service.Abstract;

namespace Uranus.Controllers
{
    public class AboutController : Controller
    {
        public readonly ITeamMemberService ObjTeamMemberService;
        public readonly ICustomerService ObjCustomerService;


        public AboutController(ITeamMemberService objTeamMemberService, ICustomerService objCustomerService)
        {
            ObjTeamMemberService = objTeamMemberService;
            ObjCustomerService = objCustomerService;
        }
        public ActionResult Index()
        {
            var teams = ObjTeamMemberService.GetAll();
            var customers = ObjCustomerService.GetAll();
            var about = new About(teams, customers);
            return View(about);
        }
    }
}