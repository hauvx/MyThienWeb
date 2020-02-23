using ConnectDataBase;
using Ngaythang;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyThienWeb.Models
{
    public class SuaLich : Connection
    {
        public DatLich Item { get; set; }
        public bool Execute()
        {
            using (var cmd = new Query())
            {
                cmd.QueryString = "update DATLICH set HOTEN =N'" + Item.hoten + "' , SDT = '" + Item.sdt+ "' , TIEUDE = N'" + Item.tieude + "' , NOIDUNG =N'" + Item.noidung + "' , NGAY = '" + Item.ngay + "' ,GIO ='" + Item.gio + "' ,TRANGTHAI='" + Item.trangthai + "' where MADL =" + Item.madl + "";

                return cmd.ExecuteQueryNonReader();
            }
        }
    }
}