using Casgem.MicroService.Shared.DTOs;
using CasgemMicroservice.Shared.DTOs;
using CasgemMicroservices.Services.Discount.DTOs;
using CasgemMicroservices.Services.Discount.Models;

namespace CasgemMicroservices.Services.Discount.Services
{
    public interface IDiscountService
    {
        Task<Response<List<ResultDiscountDTO>>> GetAllDiscountCouponsAsync();
        Task<Response<ResultDiscountDTO>> GetByIdDiscountCouponsAsync(int id);
        Task<Response<NoContent>> CreateDiscountCouponsAsync(CreateDiscountDTO discountCoupons);
        Task<Response<NoContent>> UpdateDiscountCouponsAsync(UpdateDiscountDTO updateDiscountDTO);
        Task<Response<NoContent>> DeleteDiscountCouponsAsync(int discountCouponId);
        //Task<Response<DiscountCoupons>> GetByDiscountCouponsAndUserId(string code, string userId);
    }
}