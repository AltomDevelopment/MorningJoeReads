using MorningJoeReadsWebUI.Context;
using MorningJoeReadsWebUI.Models;
using MorningJoeReadsWebUI.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MorningJoeReadsWebUI.Controllers
{
    public class SignUpController : Controller
    {
        // GET: SignUp
        public ActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignUp(SignUpViewModel model)
        {
            if (ModelState.IsValid)
            {
                using (DomainContext db = new DomainContext())
                {
                    var obj = db.Users.Where(a => a.EmailAddress.Equals(model.EmailAddress) &&
                    a.PassWord.Equals(model.PassWord)).FirstOrDefault();
                    if (obj == null)
                    {
                        User user = new User();
                        user.FirstName = model.FirstName;
                        user.LastName = model.LastName;
                        user.EmailAddress = model.EmailAddress;
                        user.PassWord = model.PassWord;

                        db.Users.Add(user);
                        db.SaveChanges();

                        return RedirectToAction(actionName: "Login", controllerName: "Login");
                    }
                }                
            }
            return View(model);                     
        }           
    }       
}