﻿using CasgemMicroservice.Services.Order.Core.Application.Features.CQRS.Commands;
using CasgemMicroservice.Services.Order.Core.Application.Interfaces;
using CasgemMicroservice.Services.Order.Core.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemMicroservice.Services.Order.Core.Application.Features.CQRS.Handlers
{
    public class CreateOrderDetailCommandHandler : IRequestHandler<CreateOrderDetailCommandRequest>
    {
        private readonly IRepository<OrderDetail> _repository;

        public CreateOrderDetailCommandHandler(IRepository<OrderDetail> repository)
        {
            _repository = repository;
        }

        public Task Handle(CreateOrderDetailCommandRequest request, CancellationToken cancellationToken)
        {
            var values = new OrderDetail
            {
                ProductId = request.ProductId,
                ProductName = request.ProductName,
                ProductPrice = request.ProductPrice,
                ProductAmount = request.ProductAmount,
                OrderDetailId = request.OrderingId
            };
            return _repository.CreateAsync(values);
        }
    }
}
