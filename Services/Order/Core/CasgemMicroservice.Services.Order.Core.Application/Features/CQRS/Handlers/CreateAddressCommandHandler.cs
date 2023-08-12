using AutoMapper;
using CasgemMicroservice.Services.Order.Core.Application.DTOs.AddressDTOs;
using CasgemMicroservice.Services.Order.Core.Application.Features.CQRS.Commands;
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
    public class CreateAddressCommandHandler : IRequestHandler<CreateAddressCommandRequest>
    {
        private readonly IRepository<Address> _repository;
        //private readonly IMapper _mapper;

        public CreateAddressCommandHandler(IRepository<Address> repository/*, IMapper mapper*/)
        {
            _repository = repository;
            //_mapper = mapper;
        }

        public Task Handle(CreateAddressCommandRequest request, CancellationToken cancellationToken)
        {
            var values = new Address
            {
                City = request.City,
                Detail = request.Detail,
                District = request.District,
                UserId = request.UserId
            };
            return _repository.CreateAsync(values);
        }
    }
}