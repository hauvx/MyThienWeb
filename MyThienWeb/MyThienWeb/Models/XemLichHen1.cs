using Ngaythang;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyThienWeb.Models
{
    public class XemLichHen1
    {
        public int ItemID { get; set; }
        public List<dynamic> Execute()
        {
            using (var cmd = new XemLichHen2())
            {
                cmd.ItemID = this.ItemID;
                return cmd.Execute();
            }
        }
    }
}