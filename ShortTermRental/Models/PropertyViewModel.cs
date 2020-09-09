using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace ShortTermRental.Models
{
    public class PropertyViewModel
    {
        public int PropertyId { get; set; }
        public string Type { get; set; }
        public string Title { get; set; }
        [Display(Name = "Guests")]
        public int MaximumGuests { get; set; }
        [Display(Name = "Overal reviews")]
        public double ReviewAverage { get; set; }
        public bool Available { get; set; }
        public string Description { get; set; }
        [Display(Name = "Has private area")]
        public bool PrivateSpace { get; set; }
        public int Bathrooms { get; set; }
        public int Bedrooms { get; set; }
        public int Beds { get; set; }

        public string Address { get; set; }
        public string City { get; set; }
        [DataType(DataType.PostalCode)]
        public string PostalCode { get; set; }
        public string Province { get; set; }
        public string Country { get; set; }
        public ICollection<string> Images { get; set; }

        [DataType(DataType.Currency)]
        //[field: AssemblyVersionAttribute("4.3.2.1")]
        //[field: AssemblyCultureAttribute("ca")]
        public double RegularRate { get; set; }
        public double PercentDiscount { get; set; }
        [DataType(DataType.Currency)]
        public double DiscountedRate { get; set; }
        [DataType(DataType.Currency)]
        public double CleaningFee { get; set; }

        public int Cleanliness { get; set; }
        public int Accuracy { get; set; }
        public int CheckIn { get; set; }
        public int Communication { get; set; }
        public int Location { get; set; }
        public int Value { get; set; }
        public int Overall { get; set; }

        public string HostName { get; set; }
    }
}
