using AutoMapper;
using CasgemMicroservice.Services.Order.Core.Application.DTOs.AddressDTOs;
using CasgemMicroservice.Services.Order.Core.Application.DTOs.OrderDTOs;
using CasgemMicroservice.Services.Order.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemMicroservice.Services.Order.Core.Application.Mappings
{
    public class OrderProfile : Profile
    {
        public OrderProfile()
        {
            CreateMap<Domain.Entities.Order, ResultOrderDTO>().ReverseMap();
            CreateMap<Domain.Entities.Order, CreateOrderDTO>().ReverseMap();
            CreateMap<Domain.Entities.Order, UpdateOrderDTO>().ReverseMap();
        }
    }
}
