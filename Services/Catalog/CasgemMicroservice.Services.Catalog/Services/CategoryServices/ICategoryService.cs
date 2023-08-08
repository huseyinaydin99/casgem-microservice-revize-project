using Casgem.MicroService.Shared.DTOs;
using CasgemMicroservice.Services.Catalog.DTOs.CategoryDTOs;
using CasgemMicroservice.Shared.DTOs;

namespace CasgemMicroservice.Services.Catalog.Services.CategoryServices
{
    public interface ICategoryService
    {
        Task<Response<List<ResultCategoryDTO>>> GetAllCategoryAsync();
        Task<Response<ResultCategoryDTO>> GetByIdCategoryAsync(string categoryId);
        Task<Response<NoContent>> CreateCategoryAsync(CreateCategoryDTO createCategoryDTO);
        Task<Response<NoContent>> DeleteCategoryAsync(string categoryId);
        Task<Response<NoContent>> UpdateCategoryAsync(UpdateCategoryDTO updateCategoryDTO);
    }
}