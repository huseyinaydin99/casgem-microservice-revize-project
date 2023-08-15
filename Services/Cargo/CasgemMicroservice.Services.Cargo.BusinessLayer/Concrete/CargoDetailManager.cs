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
    public class CargoDetailManager : ICargoDetailService
    {
        private readonly ICargoDetailDal _cargoDetailDal;

        public CargoDetailManager(ICargoDetailDal cargoDetailDal)
        {
            _cargoDetailDal = cargoDetailDal;
        }

        public void Delete(CargoDetail t)
        {
            _cargoDetailDal.Delete(t);
        }

        public List<CargoDetail> GetAll()
        {
            return _cargoDetailDal.GetAll();
        }

        public CargoDetail GetById(int id)
        {
            return _cargoDetailDal.GetById(id);
        }

        public void Insert(CargoDetail t)
        {
            _cargoDetailDal.Insert(t);
        }

        public void Update(CargoDetail t)
        {
            _cargoDetailDal.Update(t);
        }
    }
}