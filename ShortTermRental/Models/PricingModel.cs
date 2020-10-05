using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ShortTermRental.Data;

namespace ShortTermRental.Models
{
    public class PricingModel
    {
        [Required]
        [DataType(DataType.Currency)]
        [DisplayName("Please provide the nightly rate:")]
        public double RegularRate { get; set; }
        [Required]
        [DisplayName("Please percentage of discount you are willing to provide:")]
        [Range(0,50)]
        public double PercentDiscount { get; set; }
        [DataType(DataType.Currency)]
        public double DiscountedRate { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        [DisplayName("Please provide the cleaning fee:")]
        public double CleaningFee { get; set; }

        public PricingModel()
        {
        }
    }
}
