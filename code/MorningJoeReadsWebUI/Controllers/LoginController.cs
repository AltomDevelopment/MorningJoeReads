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
        public ActionResult Index()
        {           
            return View();
        }

        [HttpPost]
        public ActionResult Authorize(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                using (DomainContext db = new DomainContext())
                {
                    var userDetails = db.Users.Where(a => a.EmailAddress.Equals(model.EmailAddress) &&
                    a.PassWord.Equals(model.PassWord)).FirstOrDefault();
                    if (userDetails == null)
                    {
                        model.LoginErrorMessage = "Wrong Email Address or Password";
                        return View("Index", model);
                    }
                    else
                    {
                        Session["UserID"] = userDetails.Id;
                        return RedirectToAction("Index", "LoggedInHome");
                    }
                }
            }
            return View("Index");
            
        }
    }
}