using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ControllerViewBandingPlusPartialView.Models;

namespace ControllerViewBandingPlusPartialView.Controllers
{
    [Log]
    public class HomeController : Controller
    {
        // [OutputCache(Duration = 10)] //attribute of Result Filter
        /*
         * OutputCache is a built-in action filter attribute that can be apply to an action method for which we want to cache the output. i.e. output of the following action method will be cached for 10 seconds
         * To check, user break point below and load index page > refresh page within 10 second > breakpoint will not hit. i.e. page will be refereshed by cache.
         */
       // [Route("home/index")]

        public ActionResult Index()
        {
            string name = "use break point here";
            return View();
        }


        
        [ChildActionOnly]  //to prevent call this function by url like http://localhost:55572/home/ShowDateTime
        [OutputCache(Duration = 10)]  //implement partial cache output on same page, to check refresh the page but time will not change untile 10 second after pafe load.
        
        public string ShowDateTime()
        {
            return DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt");
        }
       // [NonAction]
        public string ShowDateTime1()
        {
            return DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
       // [HandleError] //This attribute is applied because added HandleErrorAttribute is commented.
      //  [HandleError(View = "Error")]
        public ActionResult ujjwal()
        {
            
            throw new Exception("This is unhandled exception");  //Enable <customErrors mode="On" /> in web.config

            Emp abc = new Emp() { First_name = "ujjwal", Last_name = "verma",age = 12};
            abc.staff = new Staff();
            abc.staff.First_name = "ram";
            abc.staff.Last_name = "nsbcjhsdgf";
            abc.staff.age = 20;



            return View(abc);
            //total 4 views can be created as .aspx, .ascx (<- partial) ,and  .cshtml (<- normal + partial) but ned to sppecify witch view should be load.
            //https://www.youtube.com/watch?v=X4IL0BXUMy4
            // return View("~/views/home/ujjwal1.cshtml", abc);
        }

        protected override void OnException(ExceptionContext filterContext)
        {
            string abc = "";
        }

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            int i = 10;

        }

        protected override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            int i = 10;
        }


        public string Datetime()
        {
            return DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt");
        }

        //-------------------------------------------ViewData, ViewBag, TempData ----------------------------------

        public ActionResult SampleView1()
        {
             //ViewData["CurrentDateTime"] = DateTime.Now.ToString();
            //ViewBag.CurrentDateTime = DateTime.Now.ToString();
            TempData["CurrentDateTime"] = DateTime.Now.ToString();

            //return View();
            return RedirectToAction("SampleView2");
        }

        public ActionResult SampleView2()
        {
            // string abc = ViewData["CurrentDateTime"].ToString();  //Error
            // string abc = ViewBag.CurrentDateTime;  //Error

            string abc = TempData["CurrentDateTime"].ToString();  //retain data and show on page but referesh page >Error because data lost from temp data (without keep())
            TempData.Keep(); // this is use to retain data into tempdate

            return View();
        }
    }
}