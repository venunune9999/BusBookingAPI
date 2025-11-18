using BusBookingAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace BusBookingAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<BusBookingAPI.Model.Bus> Buses { get; set; }
        public DbSet<BusBookingAPI.Model.Seat> Seats { get; set; }
        public DbSet<BusBookingAPI.Model.Booking> Bookings { get; set; }
        



    }
}
