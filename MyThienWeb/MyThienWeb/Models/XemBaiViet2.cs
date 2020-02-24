using ConnectDataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyThienWeb.Models
{
    public class XemBaiViet2 : Connection
    {
        public int MABV { get; set; }
        public List<dynamic> Execute()
        {
            using (var cmd = new Query())
            {
                cmd.QueryString = "SELECT [BAIVIET].* FROM [BAIVIET] WHERE [BAIVIET].MABV=" + MABV;
                return cmd.ExecuteQuery();
            }
        }
    }
}