using System.Threading.Tasks;
using Basket.API.Entities;

namespace Basket.API.Repositories.Interfaces
{
    public interface IBasketRepository
    {
        Task<BasketCart> GetBasketAsync(string userName);
        Task<BasketCart> UpdateBasketAsync(BasketCart basket);
        Task DeleteBasketAsync(string userName);
    }
}