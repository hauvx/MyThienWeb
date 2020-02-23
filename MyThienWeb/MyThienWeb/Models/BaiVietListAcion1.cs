using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyThienWeb.Models
{
    public class BaiVietListAcion1
    {
        public List<dynamic> Execute()
        {
            using (var cmd = new BaiVietListAcion2())
            {
                return cmd.Execute();
            }
        }
    }
}