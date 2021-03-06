﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;

namespace ShortTermRental.Data
{
    public class Property
    {
        public int Id { get; set; }
        [Required]
        //[StringLength()]
        public string Type { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public int MaximumGuests { get; set; }
        public bool Available { get; set; }
        [Required]
        public string Description { get; set; }
        public bool PrivateSpace { get; set; }
        [Required]
        public int Bathrooms { get; set; }
        [Required]
        public int Bedrooms { get; set; }
        [Required]
        public int Beds { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        [DataType(DataType.PostalCode)]
        public string PostalCode { get; set; }
        [Required]
        //[EnumDataType()]
        public string Province { get; set; }
        [Required]
        public string Country { get; set; }
        //[Required(ErrorMessage = "Please select images.")]
        //[Display(Name = "Browse File")]
        //[DataType(DataType.ImageUrl)]
        public IEnumerable<PropertyImage> Images { get; set; }
        [ForeignKey("ApplicationUser")]
        public string HostId { get; set; }
        
        [DefaultValue(0)]
        public int Cleanliness { get; set; }
        [DefaultValue(0)]
        public int Accuracy { get; set; }
        [DefaultValue(0)]
        public int CheckIn { get; set; }
        [DefaultValue(0)]
        public int Communication { get; set; }
        [DefaultValue(0)]
        public int Location { get; set; }
        [DefaultValue(0)]
        public int Value { get; set; }
        [DefaultValue(0)]
        public int Overall { get; set; }
    }
}
