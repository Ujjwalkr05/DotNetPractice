using System.Web;
using System.Web.Mvc;

namespace ControllerViewBandingPlusPartialView
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            //If we add any attribute in GlobalFilterCollection collection , it will be available at Contoller / action method level

            // filters.Add(new HandleErrorAttribute());  // i.e. HandleError Attribute is available at Controller / action method level by default. to show difference comment this line

        }
    }
}
