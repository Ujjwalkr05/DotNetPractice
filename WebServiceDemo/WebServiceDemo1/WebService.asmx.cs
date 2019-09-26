using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServiceDemo1
{
    /// <summary>
    /// Summary description for WebService
    /// </summary>
    [WebService(Namespace = "http://ujjwalKumar.com/webservices")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {

        [WebMethod]  //<---
        public int Add(int a, int b)
        {
            //List<string> calculation;// = new List<string>();
            //                         // Session["Calculation"] = calculation;
            //if (Session["CALCULATION"] != null)
            //{
            //    calculation = (List<string>)Session["CALCULATION"];
            //}
            //else
            //{
            //    calculation = new List<string>();
            //}

            //string strRecentCal = a.ToString() + "+" + b.ToString() + "=" + (a + b).ToString();
            //calculation.Add(strRecentCal);

            //Session["CALCULATION"] = calculation;

            return a + b;
        }

        [WebMethod(EnableSession = true)]
        public List<string> GetCalculation()
        {
            if (Session["CALCULATION"] != null)
            {
                return (List<string>)Session["CALCULATION"];
            }
            else
            {
                List<string> calculation = new List<string>();
                calculation.Add("You have not performed any calculation.");
                return calculation;
            }
        }
    }
}
