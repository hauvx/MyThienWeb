using MyThienWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyThienWeb.Controllers
{
    public class SloganController : Controller
    {
        // GET: Slogan
        public ActionResult Index(ShowsLogan CommandAction, bool isPopup = false)
        {
            this.ViewBag.isPopup = isPopup;
            this.ViewBag.Slogan = CommandAction.Execute();
            Session["hau"] = "hau";
            return View();
            //return PartialView("_resultSlogan", this.ViewBag.Slogan);
        }
        [HttpPost]
        public ActionResult getSlogan(ShowsLogan CommandAction, bool isPopup = false)
        {
            this.ViewBag.isPopup = isPopup;
            this.ViewBag.Slogan = CommandAction.Execute();
            return PartialView("_resultSlogan", this.ViewBag.Slogan);
        }

        public ActionResult Xemslogan(Xemslogan1 CommandAction,int masl)
        {
            CommandAction.MASL = masl;
            this.ViewBag.Result = CommandAction.Execute();
            return View();
        }
    }
}