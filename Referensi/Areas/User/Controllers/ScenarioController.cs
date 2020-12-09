using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Referensi.Areas.User.Controllers
{
    [RouteArea("User")]
    [RoutePrefix("Scenario")]
    public class ScenarioController : Controller
    {
        // GET: User/Scenario
        public ActionResult Index()
        {
            return View();
        }

        [Route("GetScenario")]
        public ActionResult GetScenario()
        {
            return View();
        }

        [Route("AddScenario")]
        public ActionResult AddScenario()
        {
            return View();
        }
    }
}