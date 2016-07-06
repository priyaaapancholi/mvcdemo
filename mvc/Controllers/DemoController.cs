using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvc.Models;

namespace mvc.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }


       public ActionResult FillCustomer()
        {
            return View("DemoView");
        }


        public ActionResult DisplayCustomer()
        {
            DemoModel dm = new DemoModel();
            dm.customer_id =Convert.ToInt16( Request.Form["cid"]);
              dm.customer_name = Request.Form["cn"];
             dm.customer_amount =Convert.ToDouble( Request.Form["camt"]);
            
            return View(dm);
        }
    }
}