using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Gaming_Store.Models;

namespace Gaming_Store.Interfaces
{
    public interface IProductRepository
    {
        Task<List<ProductDetailsDto>> GetAllProducts();
        Task<ProductDetailsDto> GetProductById(int Id);
        Task<int> CreateProduct(CreateProductDto model);
        Task<bool> UpdateProduct(UpdateProductDto model, int Id);
        Task<bool> RemoveProduct(int Id);
    }
}
