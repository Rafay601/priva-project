using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using E_projectPriva.Models;

namespace E_projectPriva.Controllers
{
    public class HomeController : Controller
    {
        Database2Entities db = new Database2Entities();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUp(Customer signup,HttpPostedFileBase img)
        {
            if(img.ContentLength > 0)
            {
                signup.Prof_Image = img.FileName;
                img.SaveAs(Server.MapPath("~/images/" + img.FileName));
            }
            else
            {
                signup.Prof_Image = "prof.png";
            }
            db.Customers.Add(signup);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Customer signup)
        {
            if (ModelState.IsValid)
            {
                var login = db.Customers.Where(a => a.Email == signup.Email && a.Password == signup.Password).FirstOrDefault();

                if (login != null)
                {
                    Session["username"] = signup.Email;
                    Session["userid"] = signup.Id;
                    return RedirectToAction("Index");
                }
                ViewBag.er = "username or password is incorrect";
                return View();
            }
            return View();
        }
        public ActionResult Logout()
        {
            Session.Remove("username");
            Session.Remove("userid");
            return RedirectToAction("Index");
        }

        public ActionResult Insurance_Cust()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Insurance_Cust(Insurance_Customer insurance_Customer)
        {
            db.Insurance_Customer.Add(insurance_Customer);
            db.SaveChanges();
            return RedirectToAction("Vehicle_Det");
        }
        public ActionResult Vehicle_Det()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Vehicle_Det(Vehicle vehicle)
        {
            db.Vehicles.Add(vehicle);
            db.SaveChanges();
            return View();
        }
    }
}