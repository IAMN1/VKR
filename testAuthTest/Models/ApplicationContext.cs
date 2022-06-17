using Microsoft.EntityFrameworkCore;

namespace ServerForAppV1.Models
{
    public class ApplicationContext : DbContext
    {
        //Создаем базу данных
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Place> Places { get; set; }
        public DbSet<User> Users { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}