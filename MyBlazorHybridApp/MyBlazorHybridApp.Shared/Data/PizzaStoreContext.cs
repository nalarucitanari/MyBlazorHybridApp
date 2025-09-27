using BlazingPizza;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MyBlazorHybridApp.Shared.Data
{
    public class PizzaStoreContext : DbContext
    {
        public PizzaStoreContext(DbContextOptions<PizzaStoreContext> options) : base(options)
        {
        }

        public DbSet<PizzaSpecial> Specials { get; set; }
    }
}
