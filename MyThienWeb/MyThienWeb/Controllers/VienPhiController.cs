using MyThienWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyThienWeb.Controllers
{
    public class VienPhiController : Controller
    {
        // GET: VienPhi
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult VienPhiList(VienPhiAction CommandAction, bool isPopup = false)
        {
            this.ViewBag.isPopup = isPopup;
            this.ViewBag.Result = CommandAction.Execute();
            return View();
        }
    }
}