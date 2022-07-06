using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using ShopBaseballBats.Models;
using ShopBaseballBats.Data;
using System.ComponentModel.DataAnnotations;


namespace ShopBaseballBats.Models
{
    public class Customer
    {
        
            public int CustomerId { get; private set; }
            public string? EmailAddress { get; set; }
            public string FirstName { get; set; }
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
            private string _lastName;
            public string LastName
            {
                get { return _lastName; }
                set { _lastName = value; }
            }
        public Address Address { get; set; }
        public string? Phone { get; set; }

    }
}
