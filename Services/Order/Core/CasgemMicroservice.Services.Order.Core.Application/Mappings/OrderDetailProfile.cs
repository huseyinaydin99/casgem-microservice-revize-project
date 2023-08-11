using AutoMapper;
using CasgemMicroservice.Services.Order.Core.Application.DTOs.OrderDetailsDTOs;
using CasgemMicroservice.Services.Order.Core.Application.DTOs.OrderingDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemMicroservice.Services.Order.Core.Application.Mappings
{
    public class OrderDetailProfile : Profile
    {
        public OrderDetailProfile()
        {
            CreateMap<Domain.Entities.OrderDetail, ResultOrderDetailDTO>().ReverseMap();
            CreateMap<Domain.Entities.OrderDetail, CreateOrderDetailDTO>().ReverseMap();
            CreateMap<Domain.Entities.OrderDetail, UpdateOrderDetailDTO>().ReverseMap();
        }
    }
}
