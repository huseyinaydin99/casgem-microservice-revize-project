using CasgemMicroservice.Services.Basket.DTOs;
using CasgemMicroservice.Shared.DTOs;

namespace CasgemMicroservice.Services.Basket.Services
{
    public interface IBasketService
    {
        Task<Response<BasketDTO>> GetBasket(string userId);
        Task<Response<bool>> SaveOrUpdate(BasketDTO basketDTO);
        Task<Response<bool>> DeleteBasket(string userId);

    }
}
