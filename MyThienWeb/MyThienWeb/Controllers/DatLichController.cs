﻿using MyThienWeb.Models;
using Ngaythang;
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

        [HttpPost]
        public ActionResult Index(DatLichExecuteSaveAction CommandAction,DatLich abc)
        {
            CommandAction.Item = abc;
            this.ViewBag.Result = CommandAction.Execute();

            return View();
        }
    }
}