using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kalendarz.Models;

namespace Kalendarz.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult AddOrEdit(int id=0)
        {
            User user = new User();
            return View();
        }

        [HttpPost]
        public ActionResult AddOrEdit(User user)
        {
            using(DBModels db=new DBModels())
            {
                if (db.User.Any(x => x.Email == user.Email))
                {
                    ViewBag.DuplicateMessage = "Użytkownik już istnieje.";
                    return View("AddOrEdit", user);
                }
                else
                {
                    db.User.Add(user);
                    db.SaveChanges();
                }
            }
            ModelState.Clear();
            ViewBag.SuccessMessage = "Rejestracja zakończona pomyślnie.";
            return View("AddOrEdit",new User());
        }
    }
}