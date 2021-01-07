using System;
using System.Collections.Generic;

namespace CarBooking.Models
{
    public class  Ticket
    {
        public int Id{get;set;}
        public decimal Price{get;set;}
        public string Phone{get;set;}
        public string Name{get;set;}
        public string Address{get;set;}
        public string SeatNumberId{get;set;}    
        public int CarId{get;set;}
        public Car Car{get;set;}
        public int RouteId{get;set;}
        public int? UserId{get;set;}
        public ApplicationUser User{get;set;}
        public Route Route{get;set;}
        public StatusTicket StatusTicket{get;set;}
        public ICollection<BookTicket> BookTickets{get;set;}
        public DateTime CreatedAt{get;set;}
        public DateTime UpdatedAt{get;set;}
    }
}