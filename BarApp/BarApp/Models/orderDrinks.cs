using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Linq.Expressions;






namespace BarApp.Models
{
    public class orderDrinks
    {
        [Display(Name = "Drink ID")]
        public int ID { get; set; }

        [Required]
        [Display(Name = "Customer Name")]
        public string CustomerName { get; set; }

        [Required]
        [Display(Name ="Drink Name")]
        public string DrinkName { get; set; }

        
        [Display(Name ="Paid Status")]
        public string PaidStatus { get; set; }

        [Display(Name ="Drink Status")]
        public string DrinkStatus { get; set; }
    }

    public enum PaidStatus
    {
        [Display(Name = "Unpaid")] Unpaid = 1,
        [Display(Name = "Piad")] Paid

    }

    public enum DrinkStatus
    {
        [Display(Name ="Unseen")]
        Unseen,

        [Display(Name ="In Progress")]
        InProgress,

        [Display (Name ="Complete")]
        Complete,

        [Display(Name = "Canceled")]
        Cancel
    }
}
