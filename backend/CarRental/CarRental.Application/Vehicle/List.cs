using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using CarRental.Domain.Dtos;
using CarRental.Application.Core;
using CarRental.Services.Interface;
using Microsoft.Extensions.Logging;
using MediatR;
using AutoMapper;

namespace CarRental.Application.Vehicle
{
    public class List
    {
        public class Query : IRequest<Result<List<VehicleDetailsDto>>> { }

        public class Handler : IRequestHandler<Query, Result<List<VehicleDetailsDto>>>
        {
            private readonly IVehicleService _vehicleService;
            private readonly IMapper _mapper;
            private readonly ILogger<List> _logger;

            public Handler(IVehicleService vehicleService, IMapper mapper, ILogger<List> logger)
            {
                _vehicleService = vehicleService ??
                    throw new ArgumentNullException(nameof(vehicleService));

                _mapper = mapper ??
                    throw new ArgumentNullException(nameof(mapper));

                _logger = logger ??
                    throw new ArgumentNullException(nameof(logger));
            }

            public async Task<Result<List<VehicleDetailsDto>>> Handle(Query request, CancellationToken cancellationToken)
            {
                var vehicleEntityList = await _vehicleService.GetAll();
                var vehicleDtoList = _mapper.Map<List<VehicleDetailsDto>>(vehicleEntityList);

                return Result<List<VehicleDetailsDto>>.Success(vehicleDtoList);
            }
        }
    }
}
