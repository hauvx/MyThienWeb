using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyThienWeb.Models
{
    public class Xemslogan1
    {
        public int MASL { get; set; }
        public List<dynamic> Execute()
        {
            using (var cmd = new Xemslogan2())
            {
                cmd.MASL = this.MASL;
                return cmd.Execute();
            }
        }
    }
}