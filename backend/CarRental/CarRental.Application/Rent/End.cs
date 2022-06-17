using AutoMapper;
using CarRental.Application.Core;
using CarRental.Services.Interface;
using MediatR;
using Microsoft.Extensions.Logging;
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
            private readonly IRentService _rentService;
            private readonly IMapper _mapper;
            private readonly ILogger<End> _logger;

            public Handler(IRentService rentService, IMapper mapper, ILogger<End> logger)
            {
                _rentService = rentService ??
                    throw new ArgumentNullException(nameof(rentService));

                _mapper = mapper ??
                    throw new ArgumentNullException(nameof(mapper));

                _logger = logger ??
                    throw new ArgumentNullException(nameof(logger));
            }

            public Task<Result<Unit>> Handle(Command request, CancellationToken cancellationToken)
            {
                throw new NotImplementedException();
            }
        }
    }
}
