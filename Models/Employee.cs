using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CarBooking.Models {
    public class Employee {
        public int Id { get; set; }

        [Required (ErrorMessage = "Vui lòng nhập họ tên")]
        public string FullName { get; set; }

        [Required (ErrorMessage = "Vui lòng chọn ngày sinh")]
        public DateTime? YearOfBirth { get; set; }

        [Required (ErrorMessage = "Vui lòng nhập số điện thoại")]
        public string Phone { get; set; }

        [Required (ErrorMessage = "Vui lòng nhập email")]
        public string Email { get; set; }

        [Required (ErrorMessage = "Vui lòng nhập địa chỉ")]
        public string Address { get; set; }

        public string Avatar { get; set; }

        public Position Position { get; set; }
        public int? CarId { get; set; }
        public Car Car { get; set; }

        public DriverLicense DriverLicense { get; set; }

        public DateTime CreatedAt { get; set; }

        public ICollection<CarHistory> CarHistories { get; set; }

    }
}