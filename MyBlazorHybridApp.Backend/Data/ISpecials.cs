using MyBlazorHybridApp.Backend.Models;

namespace MyBlazorHybridApp.Backend.Data
{
    public interface ISpecials
    {
        Task<IEnumerable<PizzaSpecial>> GetSpecials();
    }
}
