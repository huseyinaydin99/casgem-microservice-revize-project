using CasgemMicroservice.Serivces.Cargo.EntityLayer.Entities;
using CasgemMicroservice.Services.Cargo.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CasgemMicroservice.Services.Cargo.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CargoDetailsController : ControllerBase
    {
        private readonly ICargoDetailService _cargoDetailService;

        public CargoDetailsController(ICargoDetailService cargoDetailService)
        {
            _cargoDetailService = cargoDetailService;
        }

        [HttpGet]
        public IActionResult CargoDetailsList()
        {
            var values = _cargoDetailService.GetAll();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult CargoDetailGet(int id)
        {
            var value = _cargoDetailService.GetById(id);
            return Ok(value);
        }

        [HttpPost]
        public IActionResult CargoDetailCreate(CargoDetail cargoDetail)
        {
            _cargoDetailService.Insert(cargoDetail);
            return Ok("Kargo detayı eklendi.");
        }

        [HttpPut]
        public IActionResult CargoDetailUpdate(CargoDetail cargoDetail)
        {
            _cargoDetailService.Update(cargoDetail);
            return Ok("Kargo detayı güncellendi.");
        }

        [HttpDelete]
        public IActionResult CargoDetailDelete(CargoDetail cargoDetail)
        {
            _cargoDetailService.Delete(cargoDetail);
            return Ok("Kargo detayı silindi.");
        }

    }
}
