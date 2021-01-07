using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace CarBooking.Models
{
    public class ApplicationUser : IdentityUser<int>
    {
        public string FullName { get; set; }
        public string Password { get; set; }
        public string Avatar { get; set; }
        public ICollection<Ticket> Tickets { get; set; }
        public ICollection<Post> Posts {get;set;}
    }

    public class ApplicationRole : IdentityRole<int>
    {
    }
}