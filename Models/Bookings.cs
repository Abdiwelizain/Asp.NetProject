using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Airline_Reservation_System.Models
{
    public class Bookings
    {
        [Key]
        public int BookingID { get; set; }

        //[Required]
        //[ForeignKey("Users")] 
        //public int UserID { get; set; }
        //public Users? Users { get; set; }

        [Required]
        [ForeignKey("Flights")]
        public int FlightID { get; set; }
        public Flights? Flights { get; set; }

        [Required]
        public DateTime BookingDate { get; set; }

        [Required]
        [MaxLength(50)]
        public string PassengerName { get; set; }

        [Required]
        [MaxLength(20)]
        public string Status { get; set; }


    }
}
