using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Popupdesign.Feature.Header.Contollers
{
    public class HeaderController : Controller
    {
        // GET: Header
        public ActionResult Index()
        {
            return View("/Views/Popupdesign/Feature/Header.cshtml");
        }
    }
}