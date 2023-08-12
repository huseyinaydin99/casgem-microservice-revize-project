using CasgemMicroservice.Services.Order.Core.Application.DTOs.AddressDTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemMicroservice.Services.Order.Core.Application.Features.CQRS.Queries
{
    public class GetByIdAddressQueryRequest : IRequest<ResultAddressDTO>
    {
        public int Id { get; set; }

        public GetByIdAddressQueryRequest(int ıd)
        {
            Id = ıd;
        }
    }
}
