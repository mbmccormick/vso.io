using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace vso.io.Controllers
{
    public class StaticController : Controller
    {
        public ActionResult Index()
        {
            string subdomain = (string)Request.RequestContext.RouteData.Values["subdomain"];

            if (subdomain != null &&
                subdomain != "vso")
            {
                Response.StatusCode = 302;
                Response.RedirectLocation = "http://vso.io" + Request.Url.PathAndQuery;

                return new ContentResult();
            }

            return View();
        }

        public ActionResult Share()
        {
            string subdomain = (string)Request.RequestContext.RouteData.Values["subdomain"];

            if (subdomain != null &&
                subdomain != "vso")
            {
                Response.StatusCode = 302;
                Response.RedirectLocation = "http://vso.io" + Request.Url.PathAndQuery;

                return new ContentResult();
            }

            return View();
        }

        public ActionResult Error()
        {
            return View();
        }
    }
}