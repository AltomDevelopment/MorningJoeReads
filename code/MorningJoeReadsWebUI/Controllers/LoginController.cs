using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MorningJoeReadsWebUI.Context;
using MorningJoeReadsWebUI.Models;
using MorningJoeReadsWebUI.ViewModel;


namespace MorningJoeReadsWebUI.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login       
        public ActionResult Login()
        {           
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                using (DomainContext db = new DomainContext())
                {
                    var obj = db.Users.Where(a => a.EmailAddress.Equals(model.EmailAddress) &&
                    a.PassWord.Equals(model.PassWord)).FirstOrDefault();
                    if (obj != null)
                    {
                        Session["EmailAddress"] = model.EmailAddress.ToString();                       
                        return RedirectToAction("TryLogin");
                    }
                }
            }
            return View(model);
        }

        public ActionResult TryLogin()
        {
            if (Session["EmailAdress"] != null)
            {
                return View("Index", "LoggedInHome");
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

    }
}