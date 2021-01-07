using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CarBooking.Models
{
    public class Route
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Vui lòng chọn điểm xuất phát ")]
        public string StartPoint { get; set; }

        [Required(ErrorMessage = "Vui lòng chọn điểm đến ")]
        public string EndPoint { get; set; }
        [Required(ErrorMessage = "Vui lòng chọn khoảng cách ")]
        public float? Range { get; set; }
        [Required(ErrorMessage = "Vui lòng chọn thời gian xuất phát ")]
        public DateTime? TimeStart { get; set; }
        [Required(ErrorMessage = "Vui lòng chọn thời gian đến dự kiến ")]
        public DateTime? TimeEnd { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public ICollection<Ticket> Tickets { get; set; }

    }
}