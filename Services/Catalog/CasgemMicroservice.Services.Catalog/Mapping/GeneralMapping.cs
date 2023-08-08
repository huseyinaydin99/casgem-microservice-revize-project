using AutoMapper;
using CasgemMicroservice.Services.Catalog.DTOs.CategoryDTOs;
using CasgemMicroservice.Services.Catalog.DTOs.ProductDTOs;
using CasgemMicroservice.Services.Catalog.Models;

namespace CasgemMicroservice.Services.Catalog.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<Product, ResultProductDTO>().ReverseMap();
            CreateMap<Product, CreateProductDTO>().ReverseMap();
            CreateMap<Product, UpdateProductDTO>().ReverseMap();

            CreateMap<Category, ResultCategoryDTO>().ReverseMap();
            CreateMap<Category, CreateCategoryDTO>().ReverseMap();
            CreateMap<Category, UpdateCategoryDTO>().ReverseMap();
        }
    }
}
