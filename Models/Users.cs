using Microsoft.AspNetCore.Identity;

namespace Airline_Reservation_System.Models
{
    public class Users : IdentityUser
    {
        public string FullName { get; set; }
    }
}
