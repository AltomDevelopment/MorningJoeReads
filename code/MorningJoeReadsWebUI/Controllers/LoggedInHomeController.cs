﻿using MorningJoeReadsWebUI.Context;
using MorningJoeReadsWebUI.Models;
using MorningJoeReadsWebUI.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MorningJoeReadsWebUI.Controllers
{
    public class LoggedInHomeController : Controller
    {
        // GET: LoggedInHome       
        public ActionResult Index()
        {
            return View();
        }

        public Button CreateDynamicButton()
        {
            DomainContext domainContext = new DomainContext();
            Button button = new Button();

            string buttonName = domainContext.Searches.Select(a => a.SearchName).FirstOrDefault();

            button.Text = buttonName;
            return button;
        }

        public ActionResult NewSearchWindow()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UpdateSearchData(NewSearchViewModel model)
        {

            if (ModelState.IsValid)
            {
                DomainContext db = new DomainContext();

                var obj = db.Searches.Where(a => a.SearchName.Equals(model.SearchName)
                && a.SearchDescription.Equals(model.SearchDescription)).FirstOrDefault();
                if (obj == null)
                {
                    int matchId = Convert.ToInt32(Session["UserID"]);
                    
                    Search search = new Search();
                    search.SearchName = model.SearchName;
                    search.SearchDescription = model.SearchDescription;
                    search.DateCreated = DateTime.Now;
                    search.TimesViewed = 0;
                    search.Users = db.Users.Where(a => a.Id.Equals(matchId)).FirstOrDefault();
                    
                    db.Searches.Add(search);
                    db.SaveChanges();
                    
                    return RedirectToAction("Index");
                }
                if (obj.SearchName == model.SearchName && obj.SearchDescription == model.SearchDescription)
                {
                    model.SearchErrorMessage = "This search already exists";
                    return View("NewSearchWindow", model);
                }
                
            }
            return View("NewSearchWindow");

        }
        
    }
}