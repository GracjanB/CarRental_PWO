using CarRental.Application.Core;
using CarRental.Domain.Dtos;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CarRental.Application.Rent
{
    public class Details
    {
        public class Query : IRequest<Result<RentDetailsDto>>
        {
            public Guid Id { get; set; }
        }

        public class Handler : IRequestHandler<Query, Result<RentDetailsDto>>
        {
            public Task<Result<RentDetailsDto>> Handle(Query request, CancellationToken cancellationToken)
            {
                throw new NotImplementedException();
            }
        }
    }
}
