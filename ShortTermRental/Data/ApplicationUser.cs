using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace ShortTermRental.Data
{
    public class ApplicationUser : IdentityUser
    {
        //[Required]
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        //[Required]
        public string LastName { get; set; }
        //[Required]
        //[Display(Name = "Date of birth")]
        public DateTime DateOfBirth { get; set; }
        //[Required]
        public string Address { get; set; }
        //[Required]
        public string City { get; set; }
        //[Required]
        //[DataType(DataType.PostalCode)]
        public string PostalCode { get; set; }
        //[Required]
        public string Province { get; set; }
        //[Required]
        public string Country { get; set; }
        //[DataType(DataType.Currency)]
        public double? Salary { get; set; }
        public string? Position { get; set; }
        //["#nullable"]
        //public IEnumerable<ApplicationUser>? users { get; }
        public ICollection<IdentityRole> UserRoles { get; set; }
        public IEnumerable<Property> properties { get; set; }
        public IEnumerable<Booking> bookings { get; set; }
        

        public ApplicationUser() : base()
        {
            
        }

        
    }
}
