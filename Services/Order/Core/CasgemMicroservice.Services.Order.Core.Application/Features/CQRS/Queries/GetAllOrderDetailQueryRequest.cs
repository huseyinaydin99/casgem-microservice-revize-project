using CasgemMicroservice.Services.Order.Core.Application.DTOs.OrderDetailsDTOs;
using CasgemMicroservice.Services.Order.Core.Application.DTOs.OrderingDTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemMicroservice.Services.Order.Core.Application.Features.CQRS.Queries
{
    public class GetAllOrderDetailQueryRequest : IRequest<List<ResultOrderDetailDTO>>
    {

    }
}
