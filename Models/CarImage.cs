using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CarBooking.Models
{
    public class CarImage
    {
        public int Id { get; set; }
        [Required]
        public string Url { get; set; }
        [Required]
        public double Size { get; set; }
        [Required]
        public int CarId { get; set; }
        public Car Car { get; set; }
        public DateTime Created_At { get; set; }
        public DateTime Updated_At { get; set; }

    }
}