using CarRental.Application.Core;
using CarRental.Domain.Dtos;
using MediatR;
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
            public Task<Result<List<RentForListDto>>> Handle(Query request, CancellationToken cancellationToken)
            {
                throw new NotImplementedException();
            }
        }
    }
}
