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
    
    public partial class Giaban
    {
        public int magb { get; set; }
        public Nullable<int> masp { get; set; }
        public Nullable<int> giaban1 { get; set; }
        public string ngaybd { get; set; }
        public string ngaykt { get; set; }
    
        public virtual Dienthoai Dienthoai { get; set; }
    }
}
