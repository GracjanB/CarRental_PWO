using System;
using System.Threading.Tasks;
using CarRental.Domain.Dtos;
using CarRental.Application.Rent;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using MediatR;

namespace CarRental.API.Controllers
{
    [Authorize(AuthenticationSchemes = "Bearer")]
    [Route("api/[controller]")]
    [ApiController]
    public class RentController : BaseApiController
    {
        public RentController(IMediator mediator) : base(mediator) { }


        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return HandleResult(await Mediator.Send(new List.Query()));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDetailed(Guid id)
        {
            return HandleResult(await Mediator.Send(new Details.Query { Id = id }));
        }

        [HttpGet("filter")]
        public async Task<IActionResult> GetFiltered([FromQuery] RentParams rentParams)
        {
            return HandleResult(await Mediator.Send(new Filtered.Query { Params = rentParams }));
        }

        [HttpGet("filter/user/{userId}")]
        public async Task<IActionResult> GetFilteredByUser(string userId)
        {
            return HandleResult(await Mediator.Send(new FilteredByUser.Query { UserId = userId }));
        }

        [HttpGet("filter/vehicle/{vehicleId}")]
        public async Task<IActionResult> GetFilteredByVehicle(Guid vehicleId)
        {
            return HandleResult(await Mediator.Send(new FilteredByVehicle.Query { VehicleId = vehicleId }));
        }

        [HttpPost]
        public async Task<IActionResult> CreateRent(RentForCreateDto rent)
        {
            return HandleResult(await Mediator.Send(new Create.Command { Rent = rent }));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateRent(RentForUpdateDto rent)
        {
            return HandleResult(await Mediator.Send(new Update.Command { Rent = rent }));
        }

    }
}
