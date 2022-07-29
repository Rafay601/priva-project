using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using E_projectPriva.Models;

namespace Template.Controllers
{
    public class AdminController : Controller
    {
        Database2Entities db = new Database2Entities();
        //GET: Admin
        public ActionResult AdminDashboard() 
        {
            return View();
        }
        public ActionResult Orders()
        {
            return View(db.Insurance_Customer.ToList()) ;
        }

        //public ActionResult Detail_product()
        //{
        //    return View(db.Customers.ToList());
        //}

        ////public ActionResult Add_Product()
        ////{
        ////    return View();
        ////}
        ////[HttpPost]
        ////public ActionResult Add_Product(Customer pro, HttpPostedFileBase img)
        ////{
        ////    if (img.ContentLength > 0)
        ////    {
        ////        img.SaveAs(Server.MapPath("~/Content/images/" + img.FileName));
        ////        pro.Prof_Image = img.FileName;
        ////    }
        ////    db.Customers.Add(pro);
        ////    db.SaveChanges();
        ////    return RedirectToAction("Detail_product");
        ////}
        ////public ActionResult Edit_Product(int id)
        ////{
        ////    var edit = db.Customers.Where(a => a.Id == id).FirstOrDefault();

        ////    return View(edit);
        ////}
        ////[HttpPost]
        ////public ActionResult Edit_Product(Customer pro, HttpPostedFileBase img, int id)
        ////{
        ////    var edit = db.Customers.Where(a => a.Id == id).FirstOrDefault();
        ////    if (img != null)
        ////    {
        ////        if (img.ContentLength > 0)
        ////        {
        ////            img.SaveAs(Server.MapPath("~/Content/images/" + img.FileName));
        ////            edit.Prof_Image = img.FileName;
        ////        }

        ////    }
        ////    else
        ////    {
        ////        edit.Prof_Image = pro.Prof_Image;
        ////    }
        ////    edit.First_Name = pro.First_Name;
        ////    edit.Address = pro.Address;
        ////    edit.City = pro.City;
        ////    edit.Email = pro.Email;


        ////    db.SaveChanges();
        ////    return RedirectToAction("Detail_product");
        ////}
        ////public ActionResult Delete_Product(int id)
        ////{
        ////    var edit = db.Customers.Where(a => a.Id == id).FirstOrDefault();
        ////    db.Customers.Remove(edit);
        ////    db.SaveChanges();
        ////    return RedirectToAction("Detail_product");
        ////}
    }
}