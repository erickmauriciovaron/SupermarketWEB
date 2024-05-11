using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using SupermarketWEB.Models;
using System.Security.Principal;

namespace SupermarketWEB.Data
{
    public class SupermarketContext: DbContext
    {
        public SupermarketContext(DbContextOptions options) : base(options) 
        {
        }
        public DbSet<User> Acounts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<PayMode> PayModes { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Invoice>()
                .Property(p => p.Id)
                .ValueGeneratedOnAdd(); // Generar valores automáticamente al agregar
        }
    }
}
