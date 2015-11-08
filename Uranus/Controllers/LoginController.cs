using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Uranus.Domain.Entities;
using Uranus.Models;
using Uranus.Service.Abstract;
using Uranus.Service.Utility;

namespace Uranus.Controllers
{
    public class LoginController : Controller
    {
        public readonly IUserService ObjUserService;



        public LoginController(IUserService objUserService)
        {
            ObjUserService = objUserService;

        }
        //
        // GET: /Login/
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(User user)
        {
           
            if (Session["Captcha"] == null || Session["Captcha"].ToString() != user.Captcha)
            {
                foreach (var modelValue in ModelState.Values)
                {
                    modelValue.Errors.Clear();
                }
                ModelState.AddModelError("Captcha", "Wrong value of sum, please try again.");
                return View(user);
            }

            if (ObjUserService.CheckLogin(user))
            {
                SetLoginSession(user);
                Response.Redirect(FormsAuthentication.DefaultUrl, false);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("Error", "Username or Password didnot match");
                return View();
            }


        }


        [Authorize]
        public ActionResult List()
        {
            var users = ObjUserService.GetAll();
            return View(users);
        }

        [Authorize]
        //
        // GET: /Login/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Login/Create
        [Authorize]
        public ActionResult Create()
        {
            return View();
        }
        [Authorize]
        //
        // POST: /Login/Create
        [HttpPost]
        public ActionResult Create(User model)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {

                    var user = ObjUserService.Add(model);
                    if (user.UserName == CustomErrorHelper.UserAlreadyExist)
                    {
                        ModelState.AddModelError(CustomErrorHelper.UserAlreadyExist, CustomErrorHelper.UserAlreadyExist);
                        return View(model);
                    }
                    else if (user.EmailId == CustomErrorHelper.EmailAlreadyExist)
                    {
                        ModelState.AddModelError(CustomErrorHelper.EmailAlreadyExist, CustomErrorHelper.EmailAlreadyExist);
                        return View(model);
                    }
                    return RedirectToAction("List");
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

        [Authorize]
        //
        // GET: /Login/Edit/5
        public ActionResult Edit(int id)
        {
            var product = ObjUserService.GetById(id);
            return View(product);
        }

        //
        // POST: /Login/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, User user)
        {
            try
            {
                //var entity = ObjUserService.GetById(id);
                //user.Password = entity.Password;
                if (ModelState.IsValid)
                {
                    ObjUserService.Update(user);
                    return RedirectToAction("List");
                }
                else
                {
                    return View(user);
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Error", ex.Message);
                return View(user);
            }
        }
        [Authorize]
        //
        // GET: /Login/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }
        [Authorize]
        //
        // POST: /Login/Delete/5
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

        public ActionResult LogOut()
        {
            try
            {
                if (HttpContext.Session != null)
                {
                    HttpContext.Session.Clear();
                    FormsAuthentication.SignOut();
                }

                return RedirectToAction("Index", "Login");
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Login");
            }
        }
        private void SetLoginSession(User user)
        {

            var session = new UserSession(user.Id, user.UserName);

            UserSession.SetSession(session);
            int userid = UserSession.GetSession().UserId;
            FormsAuthentication.SetAuthCookie(user.UserName, false);

        }

        public ActionResult GetCaptchaImage(string prefix, bool noisy = true)
        {
            var rand = new Random((int)DateTime.Now.Ticks);

            //generate new question
            int a = rand.Next(10, 99);
            int b = rand.Next(0, 9);
            var captcha = string.Format("{0} + {1} = ?", a, b);

            //store answer
            System.Web.HttpContext.Current.Session["Captcha" + prefix] = a + b;

            //image stream
            FileContentResult img = null;

            using (var mem = new MemoryStream())
            using (var bmp = new Bitmap(130, 30))
            using (var gfx = Graphics.FromImage((Image)bmp))
            {
                gfx.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
                gfx.SmoothingMode = SmoothingMode.AntiAlias;
                gfx.FillRectangle(Brushes.White, new Rectangle(0, 0, bmp.Width, bmp.Height));

                //add noise
                if (noisy)
                {
                    int i, r, x, y;
                    var pen = new Pen(Color.Yellow);
                    for (i = 1; i < 10; i++)
                    {
                        pen.Color = Color.FromArgb(
                        (rand.Next(0, 255)),
                        (rand.Next(0, 255)),
                        (rand.Next(0, 255)));

                        r = rand.Next(0, (130 / 3));
                        x = rand.Next(0, 130);
                        y = rand.Next(0, 30);

                        gfx.DrawEllipse(pen, x - r, y - r, r, r);
                    }
                }

                //add question
                gfx.DrawString(captcha, new Font("Tahoma", 15), Brushes.Gray, 2, 3);

                //render as Jpeg
                bmp.Save(mem, System.Drawing.Imaging.ImageFormat.Jpeg);
                img = this.File(mem.GetBuffer(), "image/Jpeg");
            }

            return img;
        }

    }
}
