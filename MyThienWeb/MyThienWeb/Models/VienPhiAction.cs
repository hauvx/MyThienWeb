using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VienPhiRepository;

namespace MyThienWeb.Models
{
    public class VienPhiAction
    {
        public List<dynamic> Execute()
        {
            using (var cmd = new VienPhiSearchRepository())
            {
                return cmd.Execute();
            }
        }
    }
}