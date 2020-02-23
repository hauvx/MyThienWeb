using BaiViet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace MyThienWeb.Models
{
    public class ThemBaiVietAction1
    {
        public BaiVietHelper baiviet { get; set; }
        public string EditFlag { get; set; }
        public bool Execute()
        {
            using (var cmd = new ThemBaiVietAction2())
            {
                cmd.EditFlag = this.EditFlag;
                cmd.Item = this.baiviet;
                return cmd.Execute();
            }
        }
    }
}