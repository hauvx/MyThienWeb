using BaiViet;
using Microsoft.AspNetCore.Http;
using MyThienWeb.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyThienWeb.Controllers
{
    public class BaiVietController : Controller
    {
        // GET: BaiViet
        //show bài viết
        public ActionResult Index(BaiVietListAcion1 CommandAction)
        {
            this.ViewBag.Result = CommandAction.Execute();
            return View();
        }

        public ActionResult ThemBaiViet()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ThemBaiViet(ThemBaiVietAction1 CommandAction, BaiVietHelper abc, HttpPostedFileBase anh)
        {
            abc.ngaydang = DateTime.Now;

            if (anh != null)
            {
                var fileName = Path.GetFileName(anh.FileName);
                var rondom = Guid.NewGuid() + fileName;
                var path = Path.Combine(HttpContext.Server.MapPath("~/img/blog/"), rondom);
                if (!Directory.Exists(HttpContext.Server.MapPath("~/img/blog/")))
                {
                    Directory.CreateDirectory(HttpContext.Server.MapPath("~/img/blog/"));
                }
                anh.SaveAs(path);
                abc.anh = rondom;
                //return rondom;
            }
            else
            {
                abc.anh = "none-avatar.jpg";
            }

            /* cách này cũng đúng
            if (Request.Files.Count > 0)
            {
                var file = Request.Files[0];

                if (file != null && file.ContentLength > 0)
                {
                    var fileName = Path.GetFileName(file.FileName);
                    var path = Path.Combine(Server.MapPath("~/img/blog"), fileName);
                    file.SaveAs(path);
                }
                abc.anh = file.FileName.ToString();
            }
            else
            {
                abc.anh = "none-avatar.jpg";
            }
            */


            CommandAction.baiviet = abc;
            this.ViewBag.Result = CommandAction.Execute();

            return View();
        }

        public ActionResult XemBaiViet(XemBaiViet1 CommandAction, int mabv)
        {
            CommandAction.MABV = mabv;
            this.ViewBag.Result = CommandAction.Execute();
            return View();
        }


        public ActionResult SuaBaiViet(XemBaiViet1 CommandAction, int mabv)
        {
            CommandAction.MABV = mabv;
            this.ViewBag.Result = CommandAction.Execute();
            return View();
        }
        [HttpPost]
        public ActionResult SuaBaiViet(ThemBaiVietAction1 CommandAction, BaiVietHelper abc, HttpPostedFileBase anh,string editFlag="M")
        {
            CommandAction.EditFlag = editFlag;

            if (anh != null)
            {
                var fileName = Path.GetFileName(anh.FileName);
                var rondom = Guid.NewGuid() + fileName;
                var path = Path.Combine(HttpContext.Server.MapPath("~/img/blog/"), rondom);
                if (!Directory.Exists(HttpContext.Server.MapPath("~/img/blog/")))
                {
                    Directory.CreateDirectory(HttpContext.Server.MapPath("~/img/blog/"));
                }
                anh.SaveAs(path);
                abc.anh = rondom;
                //return rondom;
            }
            else
            {
                abc.anh = "none-avatar.jpg";
            }

            /* cách này cũng đúng
            if (Request.Files.Count > 0)
            {
                var file = Request.Files[0];

                if (file != null && file.ContentLength > 0)
                {
                    var fileName = Path.GetFileName(file.FileName);
                    var path = Path.Combine(Server.MapPath("~/img/blog"), fileName);
                    file.SaveAs(path);
                }
                abc.anh = file.FileName.ToString();
            }
            else
            {
                abc.anh = "none-avatar.jpg";
            }
            */


            CommandAction.baiviet = abc;
            this.ViewBag.Result = CommandAction.Execute();

            BaiVietListAcion1 hau = new BaiVietListAcion1();
            this.ViewBag.Result = hau.Execute();
            return View("Index");
        }

        public ActionResult XoaBaiViet(XoaBaiViet1 CommandAction, int mabv)
        {
            CommandAction.MABV = mabv;
            this.ViewBag.Result = CommandAction.Execute();
            return Redirect("Index");
        }
    }
}