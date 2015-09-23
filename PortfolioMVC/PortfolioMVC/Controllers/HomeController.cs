using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PortfolioMVC.Models;

namespace PortfolioMVC.Controllers
{

    public class HomeController : Controller
    {
        private portifolieDbEntities db = new portifolieDbEntities();
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View(db.tblusers.ToList());
        }

        public ActionResult About()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            tbluser usr = db.tblusers.Where(x => x.userName.Equals(username) && x.userPassword.Equals(password)).FirstOrDefault();
            if (usr!=null)
            {
                Session["isLoggedIn"] = usr;
            }

            return RedirectToAction("Index");
        }
        
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Portfolie(int id)
        {
            return View(db.tblusers.Find(id));
        }


        public ActionResult PortfolioEdit()
        {
            //var user = (tbluser)Session["isLoggedIn"];
            var user = db.tblusers.FirstOrDefault(x => x.ID == 1);
            //var portfolio = db.tblportfolios.FirstOrDefault(x => x.ID == user.ID);
            if (user != null)
                return View(user);
            else
                return RedirectToAction("Index");
            //return View(user);
        }

        //[HttpPost]
        //public ActionResult PortfolioEdit()
        //{

        //    return RedirectToAction("Index");
        //}
        [HttpPost]
        public ActionResult UserPost(RogueModel model)
        {
            return RedirectToAction("PortfolioEdit");
        }
    }
}
