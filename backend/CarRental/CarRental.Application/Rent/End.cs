using CarRental.Application.Core;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CarRental.Application.Rent
{
    public class End
    {
        public class Command : IRequest<Result<Unit>>
        {
            public Guid RentId { get; set; }
        }

        public class Handler : IRequestHandler<Command, Result<Unit>>
        {
            public Task<Result<Unit>> Handle(Command request, CancellationToken cancellationToken)
            {
                throw new NotImplementedException();
            }
        }
    }
}
