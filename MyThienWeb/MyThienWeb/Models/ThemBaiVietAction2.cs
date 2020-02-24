using BaiViet;
using ConnectDataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyThienWeb.Models
{
    public class ThemBaiVietAction2 : Connection
    {
        public string EditFlag { get; set; }
        public BaiVietHelper Item { get; set; }
        public bool Execute()
        {
            if (EditFlag == "M") // modifi - sua 
            {
                using (var cmd = new SuaBaiViet())
                {
                    cmd.Item = this.Item;
                    return cmd.Execute();
                }
            }
            else
            {
                using (var cmd = new ThemBaiViet())
                {
                    cmd.Item = this.Item;
                    return cmd.Execute();
                }
            }
        }
    }
}