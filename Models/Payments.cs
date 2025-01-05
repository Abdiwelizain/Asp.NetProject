using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Airline_Reservation_System.Models
{
    public class Payments
    {
        [Key] // Primary Key
        public int PaymentID { get; set; }

        [Required]
        [ForeignKey("Bookings")] 
        public int BookingID { get; set; }
        public Bookings? Booking { get; set; }

        [Required]
        public DateTime PaymentDate { get; set; }

        [Required]
        [StringLength(50)] 
        public string PaymentMethod { get; set; }

        [Required]
        [Range(0, double.MaxValue)] 
        public decimal Amount { get; set; }
    }
}
