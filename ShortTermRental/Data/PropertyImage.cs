using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShortTermRental.Data
{
    public class PropertyImage
    {
        [ForeignKey("Property")]
        public int PropertyId { get; set; }
        public string Image { get; set; }

        public virtual Property Property { get; set; }
        public PropertyImage()
        {
        }
    }
}
