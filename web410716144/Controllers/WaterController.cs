using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace web410716144.Controllers
{
    public class WaterController : Controller
    {
        // GET: Water
        public ActionResult Index(string name, float? weight)
        {
            return View();
        }
    }
}