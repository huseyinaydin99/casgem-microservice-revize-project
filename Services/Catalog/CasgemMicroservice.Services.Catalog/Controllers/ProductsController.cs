﻿using CasgemMicroservice.Services.Catalog.DTOs.ProductDTOs;
using CasgemMicroservice.Services.Catalog.Services.ProductServices;
using Microsoft.AspNetCore.Mvc;

namespace CasgemMicroservice.Services.Catalog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<IActionResult> GetProductList()
        {
            var values = await _productService.GetAllProductAsync();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductById(string productId)
        {
            var values = await _productService.GetByIdProductAsync(productId);
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductDTO createProductDTO)
        {
            var values = await _productService.CreateProductAsync(createProductDTO);
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteProduct(string productId)
        {
            await _productService.DeleteProductAsync(productId);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateProduct(UpdateProductDTO updateProductDTO)
        {
            await _productService.UpdateProductAsync(updateProductDTO);
            return Ok();
        }
    }
}