using CasgemMicroservice.Services.Order.Core.Application.DTOs.OrderingDTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemMicroservice.Services.Order.Core.Application.Features.CQRS.Queries
{
    public class GetByIdOrderingQueryRequest : IRequest<ResultOrderingDTO>
    {
        public int Id { get; set; }

        public GetByIdOrderingQueryRequest(int id)
        {
            Id = id;
        }
    }
}