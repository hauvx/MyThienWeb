using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyThienWeb.Models
{
    public class XoaLich1
    {
        public int MADL { get; set; }
        public bool Execute()
        {
            using (var cmd = new XoaLich2())
            {
                cmd.MADL = this.MADL;
                return cmd.Execute();
            }
        }
    }
}