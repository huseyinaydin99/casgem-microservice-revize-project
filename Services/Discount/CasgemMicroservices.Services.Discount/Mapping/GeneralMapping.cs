using AutoMapper;
using CasgemMicroservices.Services.Discount.DTOs;
using CasgemMicroservices.Services.Discount.Models;

namespace CasgemMicroservices.Services.Discount.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<DiscountCoupons, ResultDiscountDTO>().ReverseMap();
            CreateMap<DiscountCoupons, CreateDiscountDTO>().ReverseMap();
            CreateMap<DiscountCoupons, UpdateDiscountDTO>().ReverseMap();
        }
    }
}
