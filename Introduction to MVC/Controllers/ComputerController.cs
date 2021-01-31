using Introduction_to_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Introduction_to_MVC.Controllers
{
    public class ComputerController : Controller
    {
        // GET: Computer
        public ActionResult Display()
        {
            var MyComputer = new ComputerModel()
            {
                Name = "lenovo",
                Price = 500 
            };
            return View(MyComputer);
           
        }
    }
}