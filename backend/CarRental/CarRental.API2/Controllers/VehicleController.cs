using System;
using System.Threading.Tasks;
using CarRental.Domain.Dtos;
using CarRental.Application.Vehicle;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using MediatR;

namespace CarRental.API.Controllers
{
    [Authorize(AuthenticationSchemes = "Bearer")]
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : BaseApiController
    {
        public VehicleController(IMediator mediator) : base(mediator) { }


        [HttpGet]
        public async Task<IActionResult> GetVehicles()
        {
            return HandleResult(await Mediator.Send(new List.Query()));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDetailed(Guid id)
        {
            return HandleResult(await Mediator.Send(new Details.Query() { Id = id }));
        }

        [HttpPost]
        public async Task<IActionResult> CreateVehicle(VehicleForCreateDto vehicle)
        {
            return HandleResult(await Mediator.Send(new Create.Command() { Vehicle = vehicle }));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateVehicle(VehicleForUpdateDto vehicle)
        {
            return HandleResult(await Mediator.Send(new Update.Command() { Vehicle = vehicle }));
        }

    }
}
