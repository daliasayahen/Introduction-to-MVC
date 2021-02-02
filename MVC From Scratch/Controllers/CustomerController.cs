using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_From_Scratch.Models;

namespace MVC_From_Scratch.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult DisplayCostumer()
        {
            var CustomerModel = new CustomerModel(1 ,"dalia" , "AMMAN",26);
            return View(CustomerModel);
        }
        /*html Helper it's class
        that help to use HTML(inputText,button ...)
        in c# code using Razor */

        public ActionResult Create()
        {

            var cust = new CustomerModel();
            return View();
        }

    }
}