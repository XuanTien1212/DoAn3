﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DoAn3.Models
{
    public class LoginModel
    {
        [Key]
        [Display(Name = "Tên đăng nhập")]
        [Required(ErrorMessage = "Bạn phải nhập tài khoản!")]
        public string taikhoan { set; get; }

        [Required(ErrorMessage = "Bạn phải nhập mật khẩu!")]
        [Display(Name = "Mật khẩu")]
        public string matkhau { set; get; }

    }
}