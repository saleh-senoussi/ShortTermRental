using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace ShortTermRental.Models
{
    public class BookAccomodation
    {
        [Required]
        public string City { get; set; }

        [Required]
        public string Province { get; set; }

        [Required]
        [Display(Name ="Check in date")]
        [DataType(DataType.Date)]
        [CustomDateRange]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime CheckIn { get; set; }

        [Required]
        [Display(Name = "Check out date")]
        [DataType(DataType.Date)]
        [CustomDateRangeCheckOut("CheckIn")]//, ValidateDateGreaterThanCheckIn("CheckIn")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime CheckOut { get; set; }

        [Required]
        [Display(Name = "Number of guests")]
        [Range(1,1000)]
        public int Guests { get; set; }
    }

    public class CustomDateRangeAttribute : RangeAttribute//, IClientModelValidator
    {
        
        public CustomDateRangeAttribute() : base(typeof(DateTime), DateTime.Now.ToString("yyyy-MM-dd"), (DateTime.Now.AddYears(1)).ToString("yyyy-MM-dd"))
        { }

        public override string FormatErrorMessage(string name)
        {
            return "The field Check in date must be between " + ((DateTime)this.Minimum).ToString("yyyy-MM-dd") + " and " + ((DateTime)this.Maximum).ToString("yyyy-MM-dd")+".";
        }
    }

    public class CustomDateRangeCheckOutAttribute : RangeAttribute//, IClientModelValidator
    {
        private string DateToCompareToFieldName { get; set; }
        private DateTime checkIn { get; set; }

        public CustomDateRangeCheckOutAttribute(string dateToCompareToFieldName) : base(typeof(DateTime), DateTime.Now.ToString(), (DateTime.Now.AddYears(1)).ToString())
        {
            DateToCompareToFieldName = dateToCompareToFieldName;
        }

        
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime checkOut = ((DateTime)value);
            checkIn = (DateTime)validationContext.ObjectType.GetProperty(DateToCompareToFieldName).GetValue(validationContext.ObjectInstance, null);

            if (checkOut > checkIn)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("Check out date must be greater than check in!");
            }
        }
    }
}