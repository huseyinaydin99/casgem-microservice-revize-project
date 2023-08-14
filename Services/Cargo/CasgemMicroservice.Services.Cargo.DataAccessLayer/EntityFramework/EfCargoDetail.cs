using CasgemMicroservice.Serivces.Cargo.EntityLayer.Entities;
using CasgemMicroservice.Services.Cargo.DataAccessLayer.Abstract;
using CasgemMicroservice.Services.Cargo.DataAccessLayer.Context;
using CasgemMicroservice.Services.Cargo.DataAccessLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemMicroservice.Services.Cargo.DataAccessLayer.EntityFramework
{
    public class EfCargoDetail : GenericRepository<CargoDetail>, ICargoDetailDal
    {
        public EfCargoDetail(CargoContext context) : base(context)
        {

        }
    }
}
