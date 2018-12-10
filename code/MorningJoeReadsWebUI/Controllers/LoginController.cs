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
                    var obj = db.Users.Where(a => a.EmailAddress.Equals(model.EmailAddress) &&
                    a.PassWord.Equals(model.PassWord)).FirstOrDefault();
                    if (obj == null)
                    {
                        model.LoginErrorMessage = "Wrong Email Address or Password";
                        return View("Index", model);
                    }               
                }
            }
            return View("Index");
        }
    }
}