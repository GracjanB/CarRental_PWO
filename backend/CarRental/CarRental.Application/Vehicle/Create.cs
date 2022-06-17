using System;
using System.Threading;
using System.Threading.Tasks;
using CarRental.Domain.Dtos;
using CarRental.Application.Core;
using MediatR;

namespace CarRental.Application.Vehicle
{
    public class Create
    {
        public class Command : IRequest<Result<VehicleDetailsDto>>
        {
            public VehicleForCreateDto Vehicle { get; set; }
        }

        public class Handler : IRequestHandler<Command, Result<VehicleDetailsDto>>
        {
            public Task<Result<VehicleDetailsDto>> Handle(Command request, CancellationToken cancellationToken)
            {
                throw new NotImplementedException();
            }
        }
    }
}
