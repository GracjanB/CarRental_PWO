using System;
using CarRental.Application.Core;
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

        protected ActionResult HandleResult<T>(Result<T> result)
        {
            if (result == null) return NotFound();
            if (result.IsSuccess && result.Value != null)
                return Ok(result.Value);
            if (result.IsSuccess && result.Value == null)
                return NotFound();
            return BadRequest(result.Error);
        }
    }
}
