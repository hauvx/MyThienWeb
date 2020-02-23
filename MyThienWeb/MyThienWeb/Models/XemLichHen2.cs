using ConnectDataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyThienWeb.Models
{
    public class XemLichHen2 : Connection
    {
        public int ItemID { get; set; }
        public List<dynamic> Execute()
        {
            using (var cmd = new Query())
            {
                cmd.QueryString = "SELECT * FROM DATLICH where MADL = " + ItemID;
                return cmd.ExecuteQuery();
            }
        }
    }
}