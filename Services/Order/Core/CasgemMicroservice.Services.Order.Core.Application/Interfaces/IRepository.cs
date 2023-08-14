using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CasgemMicroservice.Services.Order.Core.Application.Interfaces
{
    public interface IRepository<T> where T : class, new()
    {
        Task<T> GetByIdAsync(int id);
        Task<List<T>> GetAllAsync();
        Task<T> CreateAsync(T t);
        Task<T> UpdateAsync(T t);
        Task<T> DeleteAsync(T t);
        Task<T> GetOrdersById(string id);
        Task<List<T>> GetOrdersById(Expression<Func<T, bool>> filter = null);
    }
}