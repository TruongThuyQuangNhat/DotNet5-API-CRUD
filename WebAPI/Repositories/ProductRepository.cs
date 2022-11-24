using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Data;
using WebAPI.Models;

namespace WebAPI.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly IDataContext _context;
        public ProductRepository(IDataContext context)
        {
            _context = context;
        }
        public async Task Add(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangeAsync();
        }

        public async Task Delete(int id)
        {
            var p = await _context.Products.FindAsync(id);

            if(p == null)
            {
                throw new NullReferenceException();
            }
            _context.Products.Remove(p);
            await _context.SaveChangeAsync();
        }

        public Task<Product> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
