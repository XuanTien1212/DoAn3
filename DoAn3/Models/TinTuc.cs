//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoAn3.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TinTuc
    {
        public int matt { get; set; }
        public string mltt { get; set; }
        public string tieude { get; set; }
        public string mand { get; set; }
        public Nullable<System.DateTime> ngaydang { get; set; }
        public string noidungdemo { get; set; }
        public string noidungchitiet { get; set; }
        public string anh { get; set; }
        public string anh1 { get; set; }
        public string anh2 { get; set; }
        public string anh3 { get; set; }
        public string anh4 { get; set; }
    
        public virtual LoaiTinTuc LoaiTinTuc { get; set; }
        public virtual Ngdung Ngdung { get; set; }
    }
}
