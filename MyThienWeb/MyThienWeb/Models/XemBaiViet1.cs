using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyThienWeb.Models
{
    public class XemBaiViet1
    {
        public int MABV { get; set; }
        public List<dynamic> Execute()
        {
            using (var cmd = new XemBaiViet2())
            {
                cmd.MABV = this.MABV;
                return cmd.Execute();
            }
        }
    }
}