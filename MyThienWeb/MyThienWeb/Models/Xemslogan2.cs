using ConnectDataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyThienWeb.Models
{
    public class Xemslogan2 : Connection
    {
        public int MASL { get; set; }
        public List<dynamic> Execute()
        {
            using (var cmd = new Query())
            {
                cmd.QueryString = "SELECT * FROM [Slogans] WHERE MASL=  "+MASL+" ";
                return cmd.ExecuteQuery();
            }
        }
    }
}