using System;
using System.Collections.Generic;
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
        public ActionResult AddSearch()
        {
            return HttpNotFound();
        }
    }
}