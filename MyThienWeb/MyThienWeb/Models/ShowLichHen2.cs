using ConnectDataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyThienWeb.Models
{
    public class ShowLichHen2 : Connection
    {
        public List<dynamic> Execute()
        {
            using (var cmd = new Query())
            {
                cmd.QueryString = "SELECT * FROM [DatLich]";
                return cmd.ExecuteQuery();
            }
        }
    }
}