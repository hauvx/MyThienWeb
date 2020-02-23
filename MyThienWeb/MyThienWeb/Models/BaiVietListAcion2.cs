using ConnectDataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyThienWeb.Models
{
    public class BaiVietListAcion2 : Connection
    {
        public List<dynamic> Execute()
        {
            using (var cmd = new Query())
            {
                cmd.QueryString = "SELECT * FROM [BAIVIET]";
                return cmd.ExecuteQuery();
            }
        }
    }
}