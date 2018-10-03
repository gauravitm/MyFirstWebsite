using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyFirstWebsite.Models;

namespace MyFirstWebsite.Controllers
{
    //created by gaurav mishra
    //this controler is used for registering students in the system
    //created on 03/10/2018
    public class StudentsController : Controller
    {
        // GET: Students
        //redering the index page to the user in browsers
        public ActionResult Index()
        {
            return View();
        }

        //rendering the student registration page in browser
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(TBL_Student_MST obj)
        {
            if(ModelState.IsValid)
            {
                HAUEntities db = new HAUEntities();
                db.TBL_Student_MST.Add(obj);
                db.SaveChanges();
            }
            return View(obj);

        }
        
        //rendering the student login page in browser
        public ActionResult Login()
        {
            return View();
        }

        //redirecting to the dashboard of user
        public ActionResult Dashboard()
        {
            return View();
        }

    }
}
