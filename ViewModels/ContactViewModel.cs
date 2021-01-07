using System;
using System.ComponentModel.DataAnnotations;

namespace CarBooking.ViewModels
{
    public class ContactViewModel
    {
        [Required(ErrorMessage = "Vui lòng nhập họ tên")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập số điện thoại")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập chủ đề")]
        [StringLength(255, ErrorMessage = "Chủ đề quá dài")]
        public string Subject { get; set; }

        [StringLength(1000, ErrorMessage = "Nội dung quá dài")]
        [Required(ErrorMessage = "Vui lòng nhập nội dung")]
        public string Message { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập Email")]
        [EmailAddress(ErrorMessage = "Email không đúng định dạng")]
        public string Email { get; set; }
    

    }
}