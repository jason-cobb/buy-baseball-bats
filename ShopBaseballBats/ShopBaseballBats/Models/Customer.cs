using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using ShopBaseballBats.Models;
using ShopBaseballBats.Data3;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace ShopBaseballBats.Models
{
    public class Customer
    {
            [Key]
        [Display(Name = "Customer #")]
        public int CustomerId { get; set; }
        [Display(Name = "Email Address")]
        public string? EmailAddress { get; set; }



        [Display(Name = "First Name")]
        public string? FirstName { get; set; }
            public string FullName
            {
                get
                {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                    {
                    if (!string.IsNullOrWhiteSpace(fullName))
                        {
                         fullName += ", ";
                        }
                        fullName += FirstName;
                    }
                return fullName;
                }
           
            }
        
        [StringLength(60), MinLength(2)]
        [Display(Name = "Last Name")]
        public string? LastName { get; set; }

        //public  Address? Address { get; set; }

        // [StringLength(13), MinLength(10)]
        [Required(ErrorMessage = "You must provide a phone number.")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
                   ErrorMessage = "Entered phone format is not valid.")]
        public string? Phone { get; set; }

        

    }
}
