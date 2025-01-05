using System.ComponentModel.DataAnnotations;

namespace Airline_Reservation_System.Models
{
    public class Flights
    {
        [Key]
        public int FlightID { get; set; }

        [Required]
        [MaxLength(50)]
        public string AirlineName { get; set; }


    }
}
