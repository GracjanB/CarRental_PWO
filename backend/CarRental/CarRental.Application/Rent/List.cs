using AutoMapper;
using CarRental.Application.Core;
using CarRental.Domain.Dtos;
using CarRental.Services.Interface;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CarRental.Application.Rent
{
    public class List
    {
        public class Query : IRequest<Result<List<RentForListDto>>> { }

        public class Handler : IRequestHandler<Query, Result<List<RentForListDto>>>
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

            public async Task<Result<List<RentForListDto>>> Handle(Query request, CancellationToken cancellationToken)
            {
                var rentsFromDb = await _rentService.GetAll();
                var rentsDtoList = _mapper.Map<List<RentForListDto>>(rentsFromDb);

                return Result<List<RentForListDto>>.Success(rentsDtoList);
            }
        }
    }
}
