using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.ApplicationInsights;

namespace vso.io.Controllers
{
    public class RedirectController : Controller
    {
        public ActionResult Redirect(string id)
        {
            string subdomain = (string)Request.RequestContext.RouteData.Values["subdomain"];

            if (subdomain == null ||
                subdomain == "vso")
            {
                throw new HttpException(400, "Bad Request");
            }

            int number = 0;
            if (int.TryParse(id, out number) == false)
            {
                throw new HttpException(400, "Bad Request");
            }

            TelemetryClient telemetry = new TelemetryClient();
            telemetry.TrackEvent("Redirect", new Dictionary<string, string> {
                { "Account", subdomain },
                { "Work Item", id }
            });

            Response.StatusCode = 302;
            Response.RedirectLocation = String.Format("https://{0}.visualstudio.com/_workitems/edit/{1}", subdomain, number);

            return new ContentResult();
        }
    }
}