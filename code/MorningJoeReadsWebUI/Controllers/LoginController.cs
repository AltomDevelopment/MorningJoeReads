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
        public ActionResult Index(LoginViewModel loginViewModel)
        {
            DomainContext db = new DomainContext();

            User user = new User();
            user.FirstName = loginViewModel.FirstName;
            user.LastName = loginViewModel.LastName;
            user.EmailAddress = loginViewModel.EmailAddress;
            user.PassWord = loginViewModel.PassWord;

            db.Users.Add(user);
            db.SaveChanges();
     
            return View();
        }
    }
}