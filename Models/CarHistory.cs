using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace CarBooking.Models
{
    public class CarHistory
    {
        public int Id{get;set;}
        public int CarId { get; set; }
        public Car Car {get;set;}
        public int EmployeeId { get; set; }
        public Employee Employee {get;set;}
        public DateTime CreatedAt{get;set;}
    }
}