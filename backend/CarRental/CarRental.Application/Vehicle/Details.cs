using System;
using System.Threading;
using System.Threading.Tasks;
using CarRental.Domain.Dtos;
using CarRental.Application.Core;
using MediatR;

namespace CarRental.Application.Vehicle
{
    public class Details
    {
        public class Query : IRequest<Result<VehicleDetailsDto>>
        {
            public Guid Id { get; set; }
        }

        public class Handler : IRequestHandler<Query, Result<VehicleDetailsDto>>
        {
            public Task<Result<VehicleDetailsDto>> Handle(Query request, CancellationToken cancellationToken)
            {
                throw new NotImplementedException();
            }
        }
    }
}
