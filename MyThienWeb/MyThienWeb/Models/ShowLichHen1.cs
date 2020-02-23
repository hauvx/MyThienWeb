using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyThienWeb.Models
{
    public class ShowLichHen1
    {
        public List<dynamic> Execute()
        {
            using (var cmd = new ShowLichHen2())
            {
                return cmd.Execute();
            }
        }
    }
}