using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyThienWeb.Controllers
{
    public class DatLichController : Controller
    {
        // GET: DatLich
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult LenLich()
        {
            return View();
        }
    }
}