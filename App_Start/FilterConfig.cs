using System.Web;
using System.Web.Mvc;
using vso.io.ErrorHandler;

namespace vso.io
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new ApplicationInsightsHandleErrorAttribute());
        }
    }
}
