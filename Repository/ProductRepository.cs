using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gaming_Store.Data;
using Gaming_Store.Interfaces;
using Gaming_Store.Models;
using Microsoft.EntityFrameworkCore;

namespace Gaming_Store.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly GamingStoreContext _context;

        public ProductRepository(GamingStoreContext context)
        {
            _context = context;
        }

        public async Task<List<ProductDetailsDto>> GetAllProducts()
        {
            var products = await _context
                                .Products
                                .Select(x => new ProductDetailsDto()
                                {
                                    ID = x.ID,
                                    Name = x.Name,
                                    Discription = x.Discription,
                                    Price = x.Price,
                                    Inventory = x.Inventory,
                                    Image = x.Image,
                                    Category = x.Category,
                                    CreationDate = x.CreationDate,
                                    UpdateDate = x.UpdateDate

                                }).ToListAsync();

            return products;
        }
        public async Task<ProductDetailsDto> GetProductById(int Id)
        {
            var product = await _context
                                .Products
                                .Where(x => x.ID == Id)
                                .Select(x => new ProductDetailsDto()
                                {
                                    ID = x.ID,
                                    Name = x.Name,
                                    Discription = x.Discription,
                                    Price = x.Price,
                                    Inventory = x.Inventory,
                                    Image = x.Image,
                                    Category = x.Category,
                                    CreationDate = x.CreationDate,
                                    UpdateDate = x.UpdateDate

                                }).FirstOrDefaultAsync();

            return product;
        }
        public async Task<int> CreateProduct(CreateProductDto model)
        {
            var product = new Product()
            {
                Name = model.Name,
                Discription = model.Discription,
                Price = model.Price,
                Inventory = model.Inventory,
                Image = model.Image,
                Category = model.Category,
            };

            _context.Add(product);
            await _context.SaveChangesAsync();

            return product.ID;
        }
    }
}
