using CasgemMicroservice.Serivces.Cargo.EntityLayer.Entities;
using CasgemMicroservice.Services.Cargo.BusinessLayer.Abstract;
using CasgemMicroservice.Services.Cargo.DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemMicroservice.Services.Cargo.BusinessLayer.Concrete
{
    public class CargoStateManager : ICargoStateService
    {
        private readonly ICargoStateDal _cargoStateDal;

        public CargoStateManager(ICargoStateDal cargoStateService)
        {
            _cargoStateDal = cargoStateService;
        }

        public void Delete(CargoState t)
        {
            _cargoStateDal.Delete(t);
        }

        public List<CargoState> GetAll()
        {
            return _cargoStateDal.GetAll();
        }

        public CargoState GetById(int id)
        {
            return _cargoStateDal.GetById(id);
        }

        public void Insert(CargoState t)
        {
            _cargoStateDal.Insert(t);
        }

        public void Update(CargoState t)
        {
            _cargoStateDal.Update(t);
        }
    }
}