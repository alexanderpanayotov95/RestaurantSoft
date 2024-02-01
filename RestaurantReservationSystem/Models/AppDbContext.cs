namespace RestaurantReservationSystem.Models
{
    // Тук добави и другите необходими using statements за моделите, ако има такива.
    using Microsoft.EntityFrameworkCore;

    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Table> Tables { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
    }
}