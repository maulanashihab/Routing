using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Referensi.Areas.Admin.Controllers
{
    //route area
    [RouteArea("Admin")]
    
    //route prefix
    [RoutePrefix("NewMenu")]
    public class MenuController : Controller
    {
        // GET: Admin/Menu
        public ActionResult Index()
        {
            return View();
        }
        //route
        [Route("AddMenu")]
        public ActionResult AddMenu()
        {
            return View();
        }

        [Route("Manage")]
        public ActionResult Manage()
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