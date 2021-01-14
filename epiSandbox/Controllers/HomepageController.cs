using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using epiSandbox.Models.Pages;
using EPiServer.Web.Mvc;

namespace epiSandbox.Controllers
{
    public class HomepageController : PageController<Homepage>
    {
        public ActionResult Index(Homepage currentPage)
        {
            return this.View(currentPage);
        }
    }
}