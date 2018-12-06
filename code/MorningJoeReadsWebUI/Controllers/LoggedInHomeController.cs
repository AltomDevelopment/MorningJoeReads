using MorningJoeReadsWebUI.Context;
using MorningJoeReadsWebUI.Models;
using MorningJoeReadsWebUI.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MorningJoeReadsWebUI.Controllers
{
    public class LoggedInHomeController : Controller
    {
        // GET: LoggedInHome       
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NewSearchWindow()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewSearchWindow(NewSearchViewModel model)
        {

            if (ModelState.IsValid)
            {
                DomainContext db = new DomainContext();

                var obj = db.Searches.Where(a => a.SearchName.Equals(model.SearchName)
                && a.SearchDescription.Equals(model.SearchDescription)).FirstOrDefault();
                if (obj == null)
                {
                    Search search = new Search();
                    search.SearchName = model.SearchName;
                    search.SearchDescription = model.SearchDescription;
                    search.DateCreated = DateTime.Now;
                    search.TimesViewed = 0;

                    db.Searches.Add(search);
                    db.SaveChanges();

                    return RedirectToAction("Index");
                }
                
            }
            return View(model);

        }
    }
}