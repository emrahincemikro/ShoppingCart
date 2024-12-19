using Microsoft.EntityFrameworkCore;
using ShoppingCart.Services.EmailAPI.Models;

namespace ShoppingCart.Services.EmailAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<EmailLogger> EmailLoggers { get; set; }
    }
}
