using System;
using System.Security.Cryptography.X509Certificates;
using ShortTermRental.Data;

namespace ShortTermRental.Models
{
    public class MyPropertiesModel
    {
        public PropertyModel Properties { get; set; }
        public PricingModel Pricings { get; set; }

        public MyPropertiesModel()
        {
            
        }
    }
}
