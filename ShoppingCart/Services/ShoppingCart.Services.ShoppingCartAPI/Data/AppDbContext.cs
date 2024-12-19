using Microsoft.EntityFrameworkCore;
using ShoppingCart.Services.ShoppingCartAPI.Models;
using System.Reflection.PortableExecutable;

namespace ShoppingCart.Services.ShoppingCartAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<CartHeader> CartHeaders { get; set; }
        public DbSet<CartDetails> CartDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

    }
}
