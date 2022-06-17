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
    public class Details
    {
        public class Query : IRequest<Result<VehicleDetailsDto>>
        {
            public Guid Id { get; set; }
        }

        public class Handler : IRequestHandler<Query, Result<VehicleDetailsDto>>
        {
            private readonly IVehicleService _vehicleService;
            private readonly IMapper _mapper;
            private readonly ILogger<Details> _logger;

            public Handler(IVehicleService vehicleService, IMapper mapper, ILogger<Details> logger)
            {
                _vehicleService = vehicleService ??
                    throw new ArgumentNullException(nameof(vehicleService));

                _mapper = mapper ??
                    throw new ArgumentNullException(nameof(mapper));

                _logger = logger ??
                    throw new ArgumentNullException(nameof(logger));
            }

            public async Task<Result<VehicleDetailsDto>> Handle(Query request, CancellationToken cancellationToken)
            {
                var vehicleEntity = await _vehicleService.GetDetailed(request.Id);

                if (vehicleEntity == null)
                {
                    return Result<VehicleDetailsDto>.Failure("Vehicle was not found");
                }

                var vehicleDto = _mapper.Map<VehicleDetailsDto>(vehicleEntity);

                return Result<VehicleDetailsDto>.Success(vehicleDto);
            }
        }
    }
}
