using CasgemMicroservice.Services.Order.Core.Application.DTOs.OrderingDTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemMicroservice.Services.Order.Core.Application.Features.CQRS.Queries
{
    //handler'a işlenmek üzere gönderilen tüm siparişleri okuyup getiren sorgu isteğidir.
    public class GetAllOrderingQueryRequest : IRequest<List<ResultOrderingDTO>>
    {
        
    }
}
