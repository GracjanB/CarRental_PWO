using AutoMapper;
using CarRental.Application.Core;
using CarRental.Domain.Dtos;
using CarRental.Services.Interface;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CarRental.Application.Rent
{
    public class Create
    {
        public class Command : IRequest<Result<RentDetailsDto>>
        {
            public RentForCreateDto Rent { get; set; }
        }

        public class Handler : IRequestHandler<Command, Result<RentDetailsDto>>
        {
            private readonly IRentService _rentService;
            private readonly IMapper _mapper;
            private readonly ILogger<Create> _logger;

            public Handler(IRentService rentService, IMapper mapper, ILogger<Create> logger)
            {
                _rentService = rentService ??
                    throw new ArgumentNullException(nameof(rentService));

                _mapper = mapper ??
                    throw new ArgumentNullException(nameof(mapper));

                _logger = logger ??
                    throw new ArgumentNullException(nameof(logger));
            }

            public async Task<Result<RentDetailsDto>> Handle(Command request, CancellationToken cancellationToken)
            {
                var rentEntity = _mapper.Map<Domain.Entity.Rent>(request.Rent);

                try
                {
                    await _rentService.Create(rentEntity);
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Error during create rent.");

                    return Result<RentDetailsDto>.Failure("Failed to create rent");
                }

                var rentDetailedEntity = _rentService.GetDetailed(rentEntity.Id).Result;
                var mapped = _mapper.Map<RentDetailsDto>(rentDetailedEntity);

                return Result<RentDetailsDto>.Success(mapped);
            }
        }
    }
}
