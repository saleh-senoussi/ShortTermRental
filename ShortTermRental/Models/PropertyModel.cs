using System;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ShortTermRental.Data;

namespace ShortTermRental.Models
{
    public class PropertyModel
    {
        public int Id { get; set; }
        [Required]
        [StringLength(25)]
        public string Type { get; set; }
        [Required]
        [StringLength(35)]
        public string Title { get; set; }
        [Required]
        [Range(1,100,ErrorMessage = "Guests capacity field is required!")]
        [DisplayName("Enter guests capacity")]
        public int MaximumGuests { get; set; }
        public bool Available { get; set; }
        [Required]
        [StringLength(225)]
        public string Description { get; set; }
        [DisplayName("Has a private space")]
        public bool PrivateSpace { get; set; }
        [Required]
        [Range(1, 100, ErrorMessage = "There should be at least a single bathroom for the guests!")]
        public int Bathrooms { get; set; }
        [Required]
        [Range(1, 100, ErrorMessage = "There should be at least a single bedroom for the guests!")]
        public int Bedrooms { get; set; }
        [Required]
        [Range(1, 100, ErrorMessage = "There should be at least a single bed for the guests!")]
        public int Beds { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        [DataType(DataType.PostalCode)]
        public string PostalCode { get; set; }
        [Required]
        public string Province { get; set; }
        [Required]
        public string Country { get; set; }
        public PropertyImage [] Images { get; set; }
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


        public PropertyModel()
        {
        }
    }
}
