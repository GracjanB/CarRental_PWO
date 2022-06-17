using System;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.API.Controllers
{
    public class BaseApiController : ControllerBase
    {
        private IMediator _mediator;
        protected IMediator Mediator
        {
            get
            {
                return _mediator;
            }
            private set
            {
                _mediator = value;
            }
        }

        public BaseApiController(IMediator mediator)
        {
            _mediator = mediator ??
                throw new ArgumentNullException(nameof(mediator));
        }
    }
}
