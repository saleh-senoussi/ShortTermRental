using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShortTermRental.Data
{
    public class Pricing
    {
        [ForeignKey("Property")]
        public int PropertyId { get; set; }
        [ForeignKey("ApplicationUser")]
        public string HostId { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public double RegularRate { get; set; }
        [Required]
        public double PercentDiscount { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public double DiscountedRate { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public double CleaningFee { get; set; }

        public virtual ApplicationUser Host { get; set; }
        public virtual Property Property { get; set; }

        public Pricing()
        {
        }
    }
}
