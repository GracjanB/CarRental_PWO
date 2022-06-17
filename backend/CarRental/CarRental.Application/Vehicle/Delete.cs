using System;
using System.Threading;
using System.Threading.Tasks;
using CarRental.Application.Core;
using MediatR;

namespace CarRental.Application.Vehicle
{
    public class Delete
    {
        public class Command : IRequest<Result<bool>>
        {
            public Guid Id { get; set; }
        }

        public class Handler : IRequestHandler<Command, Result<bool>>
        {
            public Task<Result<bool>> Handle(Command request, CancellationToken cancellationToken)
            {
                throw new NotImplementedException();
            }
        }
    }
}
