using BLL.Services.Interface;
using DAL.Models;
using DAL.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    //Implement
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repo;

        public ProductService(IProductRepository repo)
        {
            _repo = repo;
        }

        public async Task AddAsync(Product item) => await _repo.AddAsync(item);
        public async Task DeleteAsync(object id) => await _repo.DeleteAsync(id);
        public async Task<IEnumerable<Product>> GetAllAsync() => await _repo.GetAllAsync();
        public async Task<Product> GetByIdAsync(object id) => await _repo.GetByIdAsync(id);
        public async Task UpdateAsync(Product item) => await _repo.UpdateAsync(item);
    }
}
