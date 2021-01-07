using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CarBooking.Models;

namespace CarBooking.ViewModels
{
    public class TicketViewModel
    {
        public int Id { get; set; }
        public string CarCode{get;set;}
        public string RouteName{get;set;}

        public int RouteId{get;set;}
        public string Phone {get;set;}

        public string StartPoint{get;set;}
        public string Endpoint{get;set;}
        public DateTime? TimeStart{get;set;}
        public DateTime? TimeEnd{get;set;}
        public decimal Price {get;set;}
        public ICollection<Ticket> Tickets{get;set;}
        public Car Car {get;set;}
        public string SeatNumberId {get;set;}
        public string Name {get;set;}
        public string Address {get;set;}
        public StatusTicket StatusTicket {get;set;}
        public ICollection<BookTicket> BookTickets{get;set;}
        public DateTime CreatedAt{get;set;}

    }
}