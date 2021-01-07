using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CarBooking.Models;

namespace CarBooking.ViewModels
{
    public class PostIndexViewModel
    {

         public int Id {get;set;}
         public string Title {get;set;}
         public string Description {get;set;}
         public string Author{get;set;}
         public DateTime CreatedAt{get;set;}
    }
}