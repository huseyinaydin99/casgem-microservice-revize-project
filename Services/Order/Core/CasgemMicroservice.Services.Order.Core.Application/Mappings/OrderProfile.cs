using AutoMapper;
using CasgemMicroservice.Services.Order.Core.Application.DTOs.AddressDTOs;
using CasgemMicroservice.Services.Order.Core.Application.DTOs.OrderingDTOs;
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
            CreateMap<Domain.Entities.Ordering, ResultOrderingDTO>().ReverseMap();
            CreateMap<Domain.Entities.Ordering, CreateOrderDTO>().ReverseMap();
            CreateMap<Domain.Entities.Ordering, UpdateOrderDTO>().ReverseMap();
        }
    }
}
