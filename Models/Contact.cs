using System;

namespace CarBooking.Models
{
    public class  Contact
    {
        public int Id{get;set;}
        public string Name{get;set;}
        public string Email{get;set;}
        public string Phone{get;set;}
        public string Subject{get;set;}
        public string Message{get;set;}
        public bool Status{get;set;}
        public DateTime CreatedAt{get;set;}
    }
}