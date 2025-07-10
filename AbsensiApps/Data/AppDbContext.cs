using Microsoft.EntityFrameworkCore;
using AbsensiApps.Models;

namespace AbsensiApps.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Absen> Absens { get; set; }
    }
}
