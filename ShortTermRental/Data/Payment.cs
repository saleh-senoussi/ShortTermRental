using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShortTermRental.Data
{
    public class Payment
    {
        [ForeignKey("Property")]
        public int PropertyId { get; set; }
        [ForeignKey("ApplicationUser")]
        public string GuestId { get; set; }
        [ForeignKey("ApplicationUser")]
        public string HostId { get; set; }
        [ForeignKey("Booking")]
        public int BookingId { get; set; }
        [DefaultValue("Credit")]
        public PaymentType PaymentType { get; set; }
        [DefaultValue("Pending")]
        public PaymentStatus PaymentStatus { get; set; }
        /*
        public Payment()
        {

        }
        public Payment(PaymentType type)
        {
            this.PaymentType = type;
        }

        public Payment(PaymentStatus status)
        {
            this.PaymentStatus = status;
        }

        public Payment(PaymentStatus status, PaymentType type)
        {
            this.PaymentStatus = status;
            this.PaymentType = type;
        }

        public Payment(PaymentType type, PaymentStatus status)
        {
            this.PaymentStatus = status;
            this.PaymentType = type;
        }*/
    }

    public enum PaymentType
    {
        Cash,
        Credit,
        Debit,
        Cheque
    }

    public enum PaymentStatus
    {
        Completed,
        Pending
    }

}
