using Microsoft.EntityFrameworkCore;
using MyBlazorHybridApp.Backend.Models;

namespace MyBlazorHybridApp.Backend.Data
{
    public class SpecialsData : ISpecials
    {
        private readonly PizzaStoreContext _context;
        public SpecialsData(PizzaStoreContext context)
        {
            _context= context;
        }

        public async Task<IEnumerable<PizzaSpecial>> GetSpecials()
        {
            return _context.Specials
            .AsEnumerable()
            .OrderByDescending(s => s.BasePrice)
            .ToList();

        }
    }
}
