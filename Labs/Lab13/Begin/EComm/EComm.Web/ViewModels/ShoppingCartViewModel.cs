﻿using EComm.Web.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EComm.Web.ViewModels
{
    public class ShoppingCartViewModel
    {
        public ShoppingCart Cart { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string CustomerName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [CreditCard]
        [Display(Name = "Credit Card")]
        public string CreditCard { get; set; } 
    }
}
