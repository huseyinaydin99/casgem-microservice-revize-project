using CasgemMicroservice.Serivces.Cargo.EntityLayer.Entities;
using CasgemMicroservice.Services.Cargo.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CasgemMicroservice.Services.Cargo.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CargoStatesController : ControllerBase
    {
        private readonly ICargoStateService _cargoStateService;

        public CargoStatesController(ICargoStateService cargoStateService)
        {
            _cargoStateService = cargoStateService;
        }

        [HttpGet]
        public IActionResult CargoStateList()
        {
            var values = _cargoStateService.GetAll();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult CargoStateGet(int id)
        {
            var value = _cargoStateService.GetById(id);
            return Ok(value);
        }

        [HttpPost]
        public IActionResult CargoStateCreate(CargoState cargoState)
        {
            _cargoStateService.Update(cargoState);
            return Ok("Kargo durumu güncellendi.");
        }

        [HttpDelete]
        public IActionResult CargoState(CargoState cargoState)
        {
            _cargoStateService.Delete(cargoState);
            return Ok("Kargo durumu silindi.");
        }
    }
}