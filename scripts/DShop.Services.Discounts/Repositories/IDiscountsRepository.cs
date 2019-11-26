using System.Threading.Tasks;
using DShop.Services.Discounts.Domain;

namespace DShop.Services.Discounts.Repositories
{
    public interface IDiscountsRepository
    {
        Task AddAsync(Discount discount);
        Task Update(Discount discount);
    }
}
