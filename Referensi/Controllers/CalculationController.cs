using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Referensi.Controllers
{
    [RoutePrefix("Calculation")]
    public class CalculationController : Controller
    {
        // GET: Calculation
        public ActionResult Index()
        {
            return View();
        }

        [Route("Manage/{value:int}")]
        public ActionResult Manage(int value)
        {
            ViewBag.Data = value;
            return View();
        }

        [Route("Insert")]
        public ActionResult Insert()
        {
            return View();
        }
    }
}