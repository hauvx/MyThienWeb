using BaiViet;
using ConnectDataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyThienWeb.Models
{
    public class SuaBaiViet : Connection
    {
        public BaiVietHelper Item { get; set; }
        public bool Execute()
        {
            using (var cmd = new Query())
            {
                cmd.QueryString = "UPDATE [dbo].[BAIVIET] SET [TIEUDE] = N'" + Item.tieude + "',[NOIDUNGCHINH] =N'" + Item.noidungchinh + "',[ANH] = '" + Item.anh + "' WHERE [BAIVIET].MABV = " + Item.mabv;
                return cmd.ExecuteQueryNonReader();
            }
        }
    }
}