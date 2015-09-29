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
            ViewBag.Message = "";

            return View(db.tblusers.ToList());
        }

        public ActionResult About()
        {
            return View();
        }
        public ActionResult Logout()
        {
            Session["isLoggedIn"] = null;
            return RedirectToAction("Index");
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            tbluser usr = db.tblusers.Where(x => x.userName.Equals(username) && x.userPassword.Equals(password)).FirstOrDefault();
            if (usr != null)
            {
                Session["isLoggedIn"] = usr;
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Message = "Not Logged In.";
                return View();
            }
            //return View();
        }

        public ActionResult CreateUser()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateUser(string username, string password, string fullname)
        {
            tbluser usr = db.tblusers.Where(x => x.userName.Equals(username)).FirstOrDefault();
            if (usr == null)
            {
                usr = new tbluser { userName = username, userPassword = password, userFullName = fullname };
                db.tblusers.Add(usr);
                db.SaveChanges();
                Session["isLoggedIn"] = usr;
                return RedirectToAction("PortfolioEdit");
            }
            else
            {
                ViewBag.Message = "User already exist. Try another Username";
                return View();
            }
            //return View();
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
            var sessionUser = (tbluser)Session["isLoggedIn"];
            var user = db.tblusers.SingleOrDefault(x => x.ID == (sessionUser.ID));
            if (user != null)
                return View(user);
            else
                return RedirectToAction("Index");
        }


        [HttpPost]
        public ActionResult UserPost(string fullname, string description, string address, string pic)
        {   
            var sessionUser=(tbluser)Session["isLoggedIn"];
            var user = db.tblusers.SingleOrDefault(x => x.ID == (sessionUser.ID));
            user.userFullName = fullname;
            user.userDescription = description;
            user.userAddress = address;
            if(pic!=null)
                if(!pic.Equals("//Images/DefUser.png"))
                    user.userPicture = pic;
            db.SaveChanges();
            return RedirectToAction("PortfolioEdit");
        }

        [HttpPost]
        public ActionResult EducationAdd(string subject, string school, string address, DateTime from, DateTime to)
        {
            var user = GetUserWithPortfolio();
            var education = new tbleducation { eduName = subject, eduSchool = school, eduAddress = address, eduStart = from, eduFinish = to };
            user.tblportfolio.tbleducations.Add(education);
            db.SaveChanges();
            return RedirectToAction("PortfolioEdit");
        }

        [HttpPost]
        public ActionResult EducationRemove(int id)
        {
            var edu=db.tbleducations.FirstOrDefault(x => x.ID == id);
            if(edu!=null)
                db.tbleducations.Remove(edu);
            return RedirectToAction("PortfolioEdit");
        }

        [HttpPost]
        public ActionResult JobAdd(string jobname, string companyname, string companyaddress, string refferanceName, string refferanceNumber, DateTime from, DateTime to)
        {
            var user = GetUserWithPortfolio();
            user.tblportfolio.tblworks.Add(new tblwork { workStart = from, workFinish = to, workTitle = jobname, workName = companyname, workAddress = companyaddress, workReferenceName = refferanceName, workReferenceNumber = refferanceNumber });
            db.SaveChanges();
            return RedirectToAction("PortfolioEdit");
        }

        [HttpPost]
        public ActionResult JobRemove(int id)
        {
            var work = db.tblworks.FirstOrDefault(x => x.ID == id);
            if (work != null)
                db.tblworks.Remove(work);
            return RedirectToAction("PortfolioEdit");
        }

        [HttpPost]
        public ActionResult PortfolioDescription(string description)
        {
            return RedirectToAction("PortfolioEdit");
        }

        private tbluser GetUserWithPortfolio()
        {
            var sessionUser = (tbluser)Session["isLoggedIn"];
            var user = db.tblusers.SingleOrDefault(x => x.ID == (sessionUser.ID));
            var portfolio = user.tblportfolio;
            if (portfolio == null)
                user.tblportfolio = new tblportfolio();
            return user;
        }
    }
}
