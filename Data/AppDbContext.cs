using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Airline_Reservation_System.Models;

namespace UsersApp.Data
{
    public class AppDbContext : IdentityDbContext<Users>
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Bookings> Bookings { get; set; }
        public DbSet<Payments> Payments { get; set; }
        public DbSet<Flights> Flights { get; set; }
        public DbSet<AdminActions> AdminActions { get; set; }
    }
}
