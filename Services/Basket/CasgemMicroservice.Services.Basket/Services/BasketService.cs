using CasgemMicroservice.Services.Basket.DTOs;
using CasgemMicroservice.Shared.DTOs;
using System.Text.Json;

namespace CasgemMicroservice.Services.Basket.Services
{
    public class BasketService : IBasketService
    {
        private readonly RedisService _redisService;

        public BasketService(RedisService redisService)
        {
            _redisService = redisService;
        }

        public async Task<Response<bool>> DeleteBasket(string userId)
        {
            var status = await _redisService.GetDb().KeyDeleteAsync(userId);
            return status ? Response<bool>.Success(204) : Response<bool>.Fail("Sepet bulunamadı.", 204);
        }

        public async Task<Response<BasketDTO>> GetBasket(string userId)
        {
            var existBasket = await _redisService.GetDb().StringGetAsync(userId);
            if(String.IsNullOrEmpty(existBasket))
            {
                return Response<BasketDTO>.Fail("Sepet bulunamadı.", 404);
            }
            return Response<BasketDTO>.Success(JsonSerializer.Deserialize<BasketDTO>(existBasket), 200);
        }

        public async Task<Response<bool>> SaveOrUpdate(BasketDTO basketDTO)
        {
            var status = await _redisService.GetDb().StringSetAsync(basketDTO.UserId, JsonSerializer.Serialize(basketDTO));
            return status ? Response<bool>.Success(204) : Response<bool>.Fail("Sepet güncelleme veya ekleme yapılamadı.", 500);
        }
    }
}