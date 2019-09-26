using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServiceDemo
{
    /// <summary>
    /// Summary description for CalculatorWebService
    /// </summary>
    [WebService(Namespace = "http://ujjwal.com/webservices")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService] <---
    public class CalculatorWebService : System.Web.Services.WebService
    {

        [WebMethod(EnableSession = true)]  //<---
        public int Add(int firstNumber, int secondNumber)
        {
            List<string> calculation;
            if (Session["CALCULATION"] == null)
            {
                calculation = new List<string>();
            }
            else
            {
                calculation = (List<string>)Session["CALCULATION"];
            }

            string strRecentCal = firstNumber.ToString() + "+" + secondNumber.ToString() + "=" + (firstNumber + secondNumber).ToString();
            calculation.Add(strRecentCal);

            Session["CALCULATION"] = calculation;

            return firstNumber + secondNumber;
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
