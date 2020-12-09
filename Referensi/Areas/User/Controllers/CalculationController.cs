using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Referensi.Areas.User.Controllers
{
    [RouteArea("User")]
    [RoutePrefix("NewCalculation")]
    public class CalculationController : Controller
    {
        // GET: User/Calculation
        public ActionResult Index()
        {
            return View();
        }

        [Route("Add")]
        public ActionResult Add()
        {
            return View();
        }

        [Route("Modify")]
        public ActionResult Modify()
        {
            return View();
        }
    }
}