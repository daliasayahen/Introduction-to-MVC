using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Introduction_to_MVC.Controllers
{
    [RoutePrefix("Cars")]
    public class CarsController : Controller
    {
        // GET: Cars
        [Route("")]
        [Route("DaliaCars")]
        [Route("Index")]
        public ContentResult Index()
        {
            return Content("<h1>AttributeBased Routig Demo</h1>");
        }
        [Route("Detail/{id :int}")]
        public ContentResult Detail( int id)
        {
            return Content("<h3> Car ID is :" + id + "</h3> ");
        }

        [Route("Detail/{Name}")]
        public ContentResult Detail(string Name)
        {
            return Content("<h3> CarName is :" + Name + "</h3> ");
        }
    }
}