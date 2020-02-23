using ConnectDataBase;
using DatLichRepo;
using Ngaythang;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyThienWeb.Models;

namespace ClassLibrary2
{
    public class DatLichExecuteSaveBusiness : Connection
    {
        public string EditFlag { get; set; }
        public DatLich Item { get; set; }
        public bool Execute()
        {
            if (this.EditFlag == "M")
            {
                using (var cmd = new SuaLich())
                {
                    cmd.Item = this.Item;
                    return cmd.Execute();
                }
            }
            else
            {
                using (var cmd = new DatLichRepostiry())
                {
                    cmd.Item = this.Item;
                    return cmd.Execute();
                }
            }
        }
    }
}
