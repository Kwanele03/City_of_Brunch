using AppIncrements.Data.Base;
using AppIncrements.Models;

namespace AppIncrements.Data.Services
{
    public interface IProductService : IEntityBaseRepository<Product>
    {

        Task<IEnumerable<Product>> GetAllAsync();
        Task<Product> GetByIdAsync(int ProductId);
        Task AddAsync(Product product);
        Task<Product> UpdateAsync(int ProductId, Product newProduct);
        void Delete(int ProductId);

    }
}
