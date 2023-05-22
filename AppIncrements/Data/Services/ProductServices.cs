using AppIncrements.Data.Base;
using AppIncrements.Models;
using Microsoft.EntityFrameworkCore;

namespace AppIncrements.Data.Services
{
    public class ProductService : EntityBaseRepository<Product>, IProductService
    {
        private readonly AppDbContext _context;

        public ProductService(AppDbContext context) : base(context)
        {
            _context = context;
            
        }

        public async Task AddAsync(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
        }
        public void Delete(int ProductId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            var result = await _context.Products.ToListAsync();
            return result;
        }
        public async Task<Product> GetByIdAsync(int Id)
        {
            var result = await _context.Products.FirstOrDefaultAsync(n => n.Id == Id);
            return result;
        }

        public async Task<Product> UpdateAsync(int ProductId, Product newProduct)
        {
            _context.Update(newProduct);
            await _context.SaveChangesAsync();
            return newProduct;
        }
    }
}
