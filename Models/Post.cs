using System;

namespace CarBooking.Models
{
    public class  Post
    {
        public int Id{get;set;}
        public string Title{get;set;}
        public string Thumbnail{get;set;}
        public string Description{get;set;}
        public string Content{get;set;}
        public string UserId{get;set;}
        public virtual ApplicationUser User{get;set;}
        public DateTime CreatedAt{get;set;}
        public DateTime UpdatedAt{get;set;}
        

    }
}