using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication6.Controllers
{
    public class defaultController : Controller
    {
        // GET: default
        public ActionResult Index()
        {
            return View();
        }
    }
}