using ConnectDataBase;
using Ngaythang;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatLichRepo
{
    public class DatLichRepostiry : Connection
    {
        public DatLich Item { get; set; }
        public bool Execute()
        {
            using (var cmd = new Query())
            {
                cmd.QueryString = "INSERT INTO DATLICH VALUES (N'"+Item.hoten+ "', '" + Item.sdt + " ', N'" + Item.tieude + "', N'" + Item.noidung + " ', '" + Item.ngay + " ', '" + Item.gio + " ', 0)";
                return cmd.ExecuteQueryNonReader();
            }
        }
    }
}
