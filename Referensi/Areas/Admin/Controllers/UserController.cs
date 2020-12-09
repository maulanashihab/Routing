using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Referensi.Areas.Admin.Controllers
{
    [RouteArea("Admin")]
    [RoutePrefix("NewUser")]
    public class UserController : Controller
    {
        
        // GET: Admin/User
        public ActionResult Index()
        {
            return View();
        }
        [Route("Manage")]
        public ActionResult Manage()
        {
            return View();
        }

        [Route("Lock")]
        public ActionResult Lock()
        {
            return View();
        }

        [Route("Unlock")]
        public ActionResult Unlock()
        {
            return View();
        }
    }
}