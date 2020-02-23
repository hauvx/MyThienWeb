using MyThienWeb.Models;
using Ngaythang;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyThienWeb.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index(ShowLichHen1 CommandAction, bool isPopup = false)
        {
            this.ViewBag.isPopup = isPopup;
            this.ViewBag.Result = CommandAction.Execute();
            return View();
        }
        
        public ActionResult XemLichHen(XemLichHen1 CommandAction,int id)
        {
            CommandAction.ItemID = id;
            this.ViewBag.Result = CommandAction.Execute();
            return View();
        }

        public ActionResult XoaLich(XoaLich1 CommandAction ,int id)
        {
            CommandAction.MADL = id;
            this.ViewBag.Result = CommandAction.Execute();
            return Redirect("Index");

        }

        [HttpPost]
        public ActionResult SuaLichHen(DatLichExecuteSaveAction CommandAction,DatLich abc,string editFlag="M")
        {
            CommandAction.EditFlag = editFlag;
            CommandAction.Item = abc;
            this.ViewBag.bay = CommandAction.Execute();
            return Redirect("Index");
        }
    }
}