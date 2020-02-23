using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyThienWeb.Models
{
    public class ShowsLogan
    {
        public List<dynamic> Execute()
        {
            using (var cmd = new ShowsLogan1())
            {
                return cmd.Execute();
            }
        }
    }
}