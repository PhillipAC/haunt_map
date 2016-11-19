using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using haunt_map.Models;

namespace haunt_map.Controllers
{
    public class UserController : Controller
    {
        private UserDBContext db = new UserDBContext();
        //
        // GET: /User/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Register() {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(User U)
        {
            if (ModelState.IsValid)
            {
                //you should check duplicate registration here 
                db.System_Users.Add(U);
                db.SaveChanges();
                ModelState.Clear();
                U = null;
                ViewBag.Message = "Successfully Registration Done";
            }
            return View(U);
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User user)
        {
            if (ModelState.IsValid) {
                if (user.IsValid(user.UserName, user.Password))
                {
                    FormsAuthentication.SetAuthCookie(user.UserName, user.RememberMe);
                    return RedirectToAction("Index", "Home");
                }
                else {
                    ModelState.AddModelError("", "Login data is incorrect!");
                }
            }
            return View(user);
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }

    }
}
