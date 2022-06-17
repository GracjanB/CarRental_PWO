using System;
using System.Threading;
using System.Threading.Tasks;
using CarRental.Domain.Dtos;
using CarRental.Application.Core;
using CarRental.Services.Interface;
using Microsoft.Extensions.Logging;
using MediatR;
using AutoMapper;

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
            private readonly IVehicleService _vehicleService;
            private readonly IMapper _mapper;
            private readonly ILogger<Create> _logger;

            public Handler(IVehicleService vehicleService, IMapper mapper, ILogger<Create> logger)
            {
                _vehicleService = vehicleService ??
                    throw new ArgumentNullException(nameof(vehicleService));

                _mapper = mapper ??
                    throw new ArgumentNullException(nameof(mapper));

                _logger = logger ??
                    throw new ArgumentNullException(nameof(logger));
            }

            public async Task<Result<VehicleDetailsDto>> Handle(Command request, CancellationToken cancellationToken)
            {
                var vehicleEntity = _mapper.Map<Domain.Entity.Vehicle>(request.Vehicle);

                try
                {
                    await _vehicleService.Create(vehicleEntity);
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Error during create new vehicle");

                    return Result<VehicleDetailsDto>.Failure("Error during create new vehicle");
                }

                var vehicleDto = _mapper.Map<VehicleDetailsDto>(vehicleEntity);

                return Result<VehicleDetailsDto>.Success(vehicleDto);
            }
        }
    }
}
