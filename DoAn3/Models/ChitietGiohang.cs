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
    
    public partial class ChitietGiohang
    {
        public int masp { get; set; }
        public string makh { get; set; }
        public Nullable<int> soluong { get; set; }
        public Nullable<int> dongia { get; set; }
    
        public virtual Khachhang Khachhang { get; set; }
        public virtual Dienthoai Dienthoai { get; set; }
    }
}
