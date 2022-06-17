using CarRental.Application.Core;
using CarRental.Domain.Dtos;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CarRental.Application.Rent
{
    public class Update
    {
        public class Command : IRequest<Result<RentDetailsDto>>
        {
            public RentForUpdateDto Rent { get; set; }
        }

        public class Handler : IRequestHandler<Command, Result<RentDetailsDto>>
        {
            public Task<Result<RentDetailsDto>> Handle(Command request, CancellationToken cancellationToken)
            {
                throw new NotImplementedException();
            }
        }
    }
}
