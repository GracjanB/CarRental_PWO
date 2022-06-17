using System;
using System.Threading;
using System.Threading.Tasks;
using CarRental.Domain.Dtos;
using CarRental.Application.Core;
using CarRental.Domain.Exceptions;
using CarRental.Services.Interface;
using Microsoft.Extensions.Logging;
using MediatR;
using AutoMapper;

namespace CarRental.Application.Vehicle
{
    public class Update
    {
        public class Command : IRequest<Result<VehicleDetailsDto>>
        {
            public VehicleForUpdateDto Vehicle { get; set; }
        }

        public class Handler : IRequestHandler<Command, Result<VehicleDetailsDto>>
        {
            private readonly IVehicleService _vehicleService;
            private readonly IMapper _mapper;
            private readonly ILogger<Update> _logger;

            public Handler(IVehicleService vehicleService, IMapper mapper, ILogger<Update> logger)
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
                Domain.Entity.Vehicle vehicleToReturn = null;

                try
                {
                    vehicleToReturn = await _vehicleService.Update(request.Vehicle);
                }
                catch (VehicleNotFoundException ex)
                {
                    _logger.LogError(ex, "Error during update vehicle.\nVehicle with given ID does not exists");

                    return Result<VehicleDetailsDto>.Failure("Vehicle with given ID does not exists"); // To może robić błąd
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Error during update vehicle");

                    return Result<VehicleDetailsDto>.Failure("Error during update vehicle");
                }

                return Result<VehicleDetailsDto>.Success(_mapper.Map<VehicleDetailsDto>(vehicleToReturn));
            }
        }
    }
}
