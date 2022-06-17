using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using CarRental.Domain.Dtos;
using CarRental.Application.Core;
using MediatR;

namespace CarRental.Application.Vehicle
{
    public class List
    {
        public class Query : IRequest<Result<List<VehicleDetailsDto>>> { }

        public class Handler : IRequestHandler<Query, Result<List<VehicleDetailsDto>>>
        {
            public Task<Result<List<VehicleDetailsDto>>> Handle(Query request, CancellationToken cancellationToken)
            {
                throw new NotImplementedException();
            }
        }
    }
}
