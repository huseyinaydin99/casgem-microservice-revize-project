using CasgemMicroservice.Serivces.Cargo.EntityLayer.Entities;
using CasgemMicroservice.Services.Cargo.BusinessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemMicroservice.Services.Cargo.BusinessLayer.Concrete
{
    public class CargoStateManager : ICargoStateService
    {
        private readonly ICargoStateService _cargoStateService;

        public CargoStateManager(ICargoStateService cargoStateService)
        {
            _cargoStateService = cargoStateService;
        }

        public void Delete(CargoState t)
        {
            _cargoStateService.Delete(t);
        }

        public List<CargoState> GetAll()
        {
            return _cargoStateService.GetAll();
        }

        public CargoState GetById(int id)
        {
            return _cargoStateService.GetById(id);
        }

        public void Insert(CargoState t)
        {
            _cargoStateService.Insert(t);
        }

        public void Update(CargoState t)
        {
            _cargoStateService.Update(t);
        }
    }
}