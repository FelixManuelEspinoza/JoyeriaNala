using JoyeriaNala.Models;
using Microsoft.EntityFrameworkCore;
using JoyeriaNala.Models;

namespace TuProyecto.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Item> Items { get; set; }
    }
}
