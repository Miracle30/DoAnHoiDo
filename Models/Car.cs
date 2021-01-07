using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace CarBooking.Models
{
    public class Car
    {
        public int Id { get; set; }
        [Required]
        public string CarCode { get; set; }

        public string Description { get; set; }
        [Required]
        public string Thumbnail { get; set; }
        [Required]
        public int SeatNumber { get; set; }
        public int? SeatNumberRest { get; set; }
        public StatusCar StatusCar { get; set; }
        public DateTime Created_At { get; set; }
        public DateTime Updated_At { get; set; }
        public ICollection<Ticket> Tickets { get; set; }
        public ICollection<CarImage> CarImages { get; set; }
        public ICollection<Employee> Employees { get; set; }
        public ICollection<CarHistory> CarHistories { get; set; }

    }
}