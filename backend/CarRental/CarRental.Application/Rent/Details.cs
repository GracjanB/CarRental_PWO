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
    public class Details
    {
        public class Query : IRequest<Result<RentDetailsDto>>
        {
            public Guid Id { get; set; }
        }

        public class Handler : IRequestHandler<Query, Result<RentDetailsDto>>
        {
            private readonly IRentService _rentService;
            private readonly IMapper _mapper;
            private readonly ILogger<Details> _logger;

            public Handler(IRentService rentService, IMapper mapper, ILogger<Details> logger)
            {
                _rentService = rentService ??
                    throw new ArgumentNullException(nameof(rentService));

                _mapper = mapper ??
                    throw new ArgumentNullException(nameof(mapper));

                _logger = logger ??
                    throw new ArgumentNullException(nameof(logger));
            }

            public async Task<Result<RentDetailsDto>> Handle(Query request, CancellationToken cancellationToken)
            {
                var rentEntity = await _rentService.GetDetailed(request.Id);
                var rentForDetailDto = _mapper.Map<RentDetailsDto>(rentEntity);

                return Result<RentDetailsDto>.Success(rentForDetailDto);
            }
        }
    }
}
