using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Models
{
    public class UjjwalController : Controller
    {
        // GET: Ujjwal
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Report()
        {
            ViewData["name"] = "ujjwal Kumar verma";
            return View();
        }
    }
}