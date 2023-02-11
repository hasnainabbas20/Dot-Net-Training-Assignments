using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Assignment1.Models;
using System.Data.Entity;

namespace MVC_Assignment1.Controllers
{   
    public class AssignmentController : Controller
    {
        NorthwindEntities1 db = new NorthwindEntities1();
        // GET: Assignment
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CustInGermany()
        {
            return View(db.Cust_Germany().ToList());
        }

        public ActionResult CustDetails()
        {
            return View(db.Orders.Where(a => a.OrderID == 10248).ToList());
        }
    }
}