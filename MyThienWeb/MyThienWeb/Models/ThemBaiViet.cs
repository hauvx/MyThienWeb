using BaiViet;
using ConnectDataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyThienWeb.Models
{
    public class ThemBaiViet : Connection
    {
        public BaiVietHelper Item { get; set; }
        public bool Execute()
        {
            using (var cmd = new Query())
            {
                cmd.QueryString = "INSERT INTO [dbo].[BAIVIET]([TIEUDE] ,[NOIDUNGCHINH] ,[ANH] ,[NGAYDANG]) VALUES (N'"+Item.tieude+ "',N'" + Item.noidungchinh + "','" + Item.anh + "','" + Item.ngaydang + "')";
                return cmd.ExecuteQueryNonReader(); ;
            }
        }
    }
}