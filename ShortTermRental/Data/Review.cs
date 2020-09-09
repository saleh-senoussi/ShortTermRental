using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ShortTermRental.Data
{
    public class Review
    {
        [ForeignKey("Property")]
        public int PropertyId { get; set; }
        [ForeignKey("ApplicationUser")]
        public string GuestId { get; set; }
        [ForeignKey("Booking")]
        public int BookingId { get; set; }
        [Required]
        [Range(1,5)]
        public int Cleanliness { get; set; }
        [Required]
        [Range(1, 5)]
        public int Accuracy { get; set; }
        [Required]
        [Range(1, 5)]
        public int CheckIn { get; set; }
        [Required]
        [Range(1, 5)]
        public int Communication { get; set; }
        [Required]
        [Range(1, 5)]
        public int Location { get; set; }
        [Required]
        [Range(1, 5)]
        public int Value { get; set; }
        [Required]
        [Range(1, 5)]
        public int Overall { get; set; }
        [Required]
        [StringLength(200)]
        public string Comments { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }
        /*
        public virtual Property Property { get; set; }
        public virtual ApplicationUser Guest { get; set; }
        public virtual Booking Booking { get; set; }
        */
        public Review()
        {
        }
    }
}
