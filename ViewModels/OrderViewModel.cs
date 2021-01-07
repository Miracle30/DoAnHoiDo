using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CarBooking.Models;

namespace CarBooking.ViewModels
{
    public class OrderViewModel
    {

         public int Id {get;set;}
         public int Amount {get;set;}
         public Route Route {get;set;}
         public Car Car {get;set;}
         public DateTime CreatedAt{get;set;}
    }
}