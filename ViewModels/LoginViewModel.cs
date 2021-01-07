using System;
using System.ComponentModel.DataAnnotations;

namespace CarBooking.ViewModels
{
    public class LoginViewModel
    {

        [Required(ErrorMessage = "Vui lòng nhập Email")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập mật khẩu")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        
        [Display(Name = "Ghi nhớ đăng nhập")] 

        public string ReturnUrl {set;get;}
        public bool RememberMe {get;set;}


    }
}