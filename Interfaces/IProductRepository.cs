using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Gaming_Store.Models;

namespace Gaming_Store.Interfaces
{
    public interface IProductRepository
    {
        Task<List<ProductDetailsDto>> GetAllProducts();
    }
}
