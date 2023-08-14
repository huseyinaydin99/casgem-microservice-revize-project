using CasgemMicroservice.Serivces.Cargo.EntityLayer.Entities;
using CasgemMicroservice.Services.Cargo.BusinessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemMicroservice.Services.Cargo.BusinessLayer.Concrete
{
    public class CargoDetailManager : ICargoDetailService
    {
        private readonly ICargoDetailService _cargoDetailService;

        public CargoDetailManager(ICargoDetailService cargoDetailService)
        {
            _cargoDetailService = cargoDetailService;
        }

        public void Delete(CargoDetail t)
        {
            _cargoDetailService.Delete(t);
        }

        public List<CargoDetail> GetAll()
        {
            return _cargoDetailService.GetAll();
        }

        public CargoDetail GetById(int id)
        {
            return _cargoDetailService.GetById(id);
        }

        public void Insert(CargoDetail t)
        {
            _cargoDetailService.Insert(t);
        }

        public void Update(CargoDetail t)
        {
            _cargoDetailService.Update(t);
        }
    }
}