using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
            //var user = Session["isLoggedIn"];
            //ViewBag.Message = "Your app description page.";
            //if (user != null)
            //{
                return View();
            //}
            //else
            //{
            //    return RedirectToAction("Index");
            //}
                        
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

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Portfolie(int id)
        {
            return View(db.tblusers.Find(id));
        }

        public ActionResult PortfolioEdit(){
            var user = (tbluser)Session["isLoggedIn"];
            var portfolio = db.tblportfolios.FirstOrDefault(x => x.ID == user.ID);
            if (user != null&&portfolio!=null)
                return View(portfolio);
            else
                return RedirectToAction("Index");
        }
    }
}
