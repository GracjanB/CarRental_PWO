using AutoMapper;
using CarRental.Application.Core;
using CarRental.Domain.Dtos;
using CarRental.Domain.Exceptions;
using CarRental.Services.Interface;
using MediatR;
using Microsoft.Extensions.Logging;
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

            public async Task<Result<RentDetailsDto>> Handle(Command request, CancellationToken cancellationToken)
            {
                var rentEntity = _mapper.Map<Domain.Entity.Rent>(request.Rent);

                try
                {
                    await _rentService.Update(rentEntity);
                }
                catch (RentNotFoundException ex)
                {
                    _logger.LogInformation("Rent not found", ex);
                    return Result<RentDetailsDto>.Failure("Rent with given id was not found");
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "An error occured during update rent");
                    return Result<RentDetailsDto>.Failure("An error occured during update rent. Try again later");
                }

                var rentDetailedEntity = await _rentService.GetDetailed(rentEntity.Id);

                return Result<RentDetailsDto>.Success(_mapper.Map<RentDetailsDto>(rentDetailedEntity));
            }
        }
    }
}
