using App1.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App1.Services
{
    internal interface IProductRepository
    {
        Task<bool> AddProductAsync(ProductInfo product);
        Task<bool> DeleteProductAsync(int id);
        Task<ProductInfo> GetProductAsync(int id);
        Task<IEnumerable<ProductInfo>> GetProductsAsync();

    }
}
