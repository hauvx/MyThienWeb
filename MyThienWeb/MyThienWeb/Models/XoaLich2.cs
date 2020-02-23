using ConnectDataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyThienWeb.Models
{
    public class XoaLich2 : Connection
    {
        public int MADL { get; set; }
        public bool Execute()
        {
            using (var cmd = new Query())
            {
                cmd.QueryString = "DELETE FROM [DatLich] WHERE MADL = " + this.MADL;
                return cmd.ExecuteQueryNonReader();
            }
        }
    }
}