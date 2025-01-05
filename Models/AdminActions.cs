using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Airline_Reservation_System.Models
{
    public class AdminActions
    {
        [Key] 
        public int ActionID { get; set; }

        //[Required]
        //[ForeignKey("Users")]
        //public int UserID { get; set; }
        //public Users? Users { get; set; }

        [Required]
        public DateTime ActionDate { get; set; }




    }
}
