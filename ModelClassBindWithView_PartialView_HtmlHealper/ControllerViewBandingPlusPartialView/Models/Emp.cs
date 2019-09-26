using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControllerViewBandingPlusPartialView.Models
{
    public class Emp
    {
        public string First_name { set; get; }
        public string Last_name { set; get; }
        public int age { set; get; }

        public Staff staff;

    }

    public class Staff
    {
        public string First_name { set; get; }
        public string Last_name { set; get; }
        public int age { set; get; }

    }
}