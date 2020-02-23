
using ClassLibrary2;
using Ngaythang;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyThienWeb.Models
{
    public class DatLichExecuteSaveAction
    {
        public DatLich Item { get; set; }
        public string EditFlag { get; set; }
        public bool Execute()
        {
            using (var cmd = new DatLichExecuteSaveBusiness())
            {
                cmd.EditFlag = this.EditFlag;
                cmd.Item = this.Item;
                return cmd.Execute();
            }
        }
    }
}