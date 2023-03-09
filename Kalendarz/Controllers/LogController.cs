using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Kalendarz.Models;

namespace Kalendarz.Controllers
{
    public class LogController : Controller
    {
        // GET: Log
        DBModels db = new DBModels();
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(User user)
        {
            var userDetail = db.User.Where(x => x.Email == user.Email && x.Haslo == user.Haslo).Count();
            if(userDetail>0)
            {
                return RedirectToAction("Dashborad");
            }
            else
            {
                return RedirectToAction("Dashborad2");
            }
        }

        public ActionResult Dashborad()
        {
            return View();
        }

        public ActionResult Dashborad2()
        {
            return View();
        }
    }
}