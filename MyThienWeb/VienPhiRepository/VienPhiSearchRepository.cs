using ConnectDataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VienPhiRepository
{
    public class VienPhiSearchRepository : Connection
    {
        public List<dynamic> Execute()
        {
            using (var cmd = new Query())
            {
                cmd.QueryString = "SELECT ChiDanh, DonGia FROM [VienPhi]";
                return cmd.ExecuteQuery();
            }
        }
    }
}
