using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstWebsite.Controllers
{
    //public acess modifier
    //:controller name of class and links controller is intheritated from controller class

    public class LinksController : Controller
    {
        // GET: Links
        //public means 
        //return type is action results

        public ActionResult Index()
        {
            //render view 
            return View();
        }
    }
}