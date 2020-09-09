using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ShortTermRental.Data
{
    public class Booking
    {
        public int Id { get; set; }
        [Required]
        [ForeignKey("Property")]
        public int PropertyId { get; set; }
        [Required]
        [ForeignKey("ApplicationUser")]
        public string GuestId { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}", ApplyFormatInEditMode = true)]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime SigningDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime StartingDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EndingDate { get; set; }

        public virtual Property Property { get; set; }
        public virtual ApplicationUser Guest { get; set; }

        public Booking()
        {
        }

        
    }
}
