using AutoMapper;
using Casgem.MicroService.Shared.DTOs;
using CasgemMicroservice.Shared.DTOs;
using CasgemMicroservices.Services.Discount.Context;
using CasgemMicroservices.Services.Discount.DTOs;
using CasgemMicroservices.Services.Discount.Models;
using Microsoft.EntityFrameworkCore;

namespace CasgemMicroservices.Services.Discount.Services
{
    public class DiscountService : IDiscountService
    {
        private readonly DapperContext _dapperContext;
        private readonly IMapper _mapper;

        public DiscountService(DapperContext dapperContext, IMapper mapper)
        {
            _dapperContext = dapperContext;
            _mapper = mapper;
        }

        public async Task<Response<NoContent>> CreateDiscountCouponsAsync(CreateDiscountDTO createDiscountDTO)
        {
            var createCoupon = _mapper.Map<DiscountCoupons>(createDiscountDTO);
            createCoupon.CreatedTime = DateTime.Now;
            await _dapperContext.DiscountCouponses.AddAsync(createCoupon);
            return Response<NoContent>.Success(201);
        }

        public async Task<Response<NoContent>> DeleteDiscountCouponsAsync(int discountCouponId)
        {
            var result = await _dapperContext.DiscountCouponses.FindAsync(discountCouponId);
            if(result == null)
            {
                return Response<NoContent>.Fail("Silinecek kupon bulunamadı.", 404);
            }
            _dapperContext.DiscountCouponses.Remove(result);
            await _dapperContext.SaveChangesAsync();
            return Response<NoContent>.Success(204);
        }

        public async Task<Response<List<ResultDiscountDTO>>> GetAllDiscountCouponsAsync()
        {
            var values = await _dapperContext.DiscountCouponses.ToListAsync();
            return Response<List<ResultDiscountDTO>>.Success(_mapper.Map<List<ResultDiscountDTO>>(values),204);
        }

        public async Task<Response<ResultDiscountDTO>> GetByIdDiscountCouponsAsync(int id)
        {
            var result = await _dapperContext.DiscountCouponses.FindAsync(id);
            return Response<ResultDiscountDTO>.Success(_mapper.Map<ResultDiscountDTO>(result), 200);
        }

        public async Task<Response<NoContent>> UpdateDiscountCouponsAsync(UpdateDiscountDTO updateDiscountDTO)
        {
            var existingResponse = await _dapperContext.DiscountCouponses.FindAsync(updateDiscountDTO.DiscountCouponsId);
            if(existingResponse == null)
            {
                return Response<NoContent>.Fail("Güncellemek kupon bulunamadı.", 404);
            }
            _mapper.Map(updateDiscountDTO, existingResponse);
            _dapperContext.DiscountCouponses.Update(existingResponse);
            _dapperContext.SaveChangesAsync();
            return Response<NoContent>.Success(204);
        }
    }
}