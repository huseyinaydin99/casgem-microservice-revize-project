using CasgemMicroservice.Services.Cargo.DataAccessLayer.Abstract;
using CasgemMicroservice.Services.Cargo.DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemMicroservice.Services.Cargo.DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class, new()
    {
        private readonly CargoContext _cargoContext;

        public GenericRepository(CargoContext cargoContext)
        {
            _cargoContext = cargoContext;
        }

        public void Delete(T t)
        {
            _cargoContext.Set<T>().Remove(t);
            _cargoContext.SaveChanges();
        }

        public List<T> GetAll()
        {
            return _cargoContext.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _cargoContext.Set<T>().Find(id);
        }

        public void Insert(T t)
        {
            _cargoContext.Set<T>().Add(t);
            _cargoContext.SaveChanges();
        }

        public void Update(T t)
        {
            _cargoContext.Set<T>().Update(t);
            _cargoContext.SaveChanges();
        }
    }
}
