using Microsoft.EntityFrameworkCore;
using MyBlazorHybridApp.Backend.Models;

namespace MyBlazorHybridApp.Backend.Data
{
    public class PizzaStoreContext : DbContext
    {
        public PizzaStoreContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<PizzaSpecial> Specials { get; set; }
    }
}
