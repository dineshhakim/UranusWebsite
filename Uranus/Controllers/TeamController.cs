using System;
using System.Collections.Generic;
using System.IO;
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
    public class TeamController : Controller
    {
        public readonly ITeamMemberService ObjTeamMemberService;
        public TeamController(ITeamMemberService objTeamMemberService)
        {
            this.ObjTeamMemberService = objTeamMemberService;

        }
        //
        // GET: /Team/
        public ActionResult Index()
        {
            var teams = ObjTeamMemberService.GetAll();
            return View(teams);
        }

       

        //
        // GET: /Team/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Team/Create
        [HttpPost]
        public ActionResult Create(TeamMember team)
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
                        return View(team);
                    }
                    team.ImageUrl = filename;
                    ObjTeamMemberService.Add(team);
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(team);
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Error", ex.Message);
                return View(team);
            }
        }

        //
        // GET: /Team/Edit/5
        public ActionResult Edit(int id)
        {
            var team = ObjTeamMemberService.GetById(id);
            return View(team);
        }

        //
        // POST: /Team/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, TeamMember teamMember)
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
                        return View(teamMember);
                    }
                    teamMember.ImageUrl = filename;
                    ObjTeamMemberService.Update(teamMember);
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(teamMember);
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Error", ex.Message);
                return View(teamMember);
            }
        }

        //
        // GET: /Team/Delete/5
        public ActionResult Delete(int id)
        {
            var team = ObjTeamMemberService.GetById(id);
            return View(team);
        }

        //
        // POST: /Team/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                var team = ObjTeamMemberService.GetById(id);
                ObjTeamMemberService.Delete(team);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


    }
}
