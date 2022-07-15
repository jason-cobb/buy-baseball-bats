using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using ShopBaseballBats.Models;
using ShopBaseballBats.Data2;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace ShopBaseballBats.Models
{
    public class Customer
    {
            [Key]
            public int CustomerId { get; private set; }
       
            public string? EmailAddress { get; set; }

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
            public string? LastName { get; set; }
           
        //public  Address? Address { get; set; }
        [StringLength(13), MinLength(10)]
       // [DataType(DataType.PhoneNumber)]
        public string? Phone { get; set; }

        

    }
}
