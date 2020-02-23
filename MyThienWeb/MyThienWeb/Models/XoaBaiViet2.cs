using ConnectDataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyThienWeb.Models
{
    public class XoaBaiViet2 : Connection
    {
        public int MABV { get; set; }
        public bool Execute()
        {
            using (var cmd = new Query())
            {
                cmd.QueryString = "DELETE FROM [BAIVIET] WHERE [BAIVIET].MABV = " + MABV;
                return cmd.ExecuteQueryNonReader();
            }
        }
    }
}