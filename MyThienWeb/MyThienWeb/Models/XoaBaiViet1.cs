using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyThienWeb.Models
{
    public class XoaBaiViet1
    {
        public int MABV { get; set; }
        public bool Execute()
        {
            using (var cmd = new XoaBaiViet2())
            {
                cmd.MABV = this.MABV;
                return cmd.Execute();
            }
        }
    }
}