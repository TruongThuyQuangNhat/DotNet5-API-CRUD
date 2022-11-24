using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Repositories
{
    interface IProductRepository
    {
        Task<Product> Get(int id);
        Task<IEnumerable> GetAll();
        Task Add(Product product);
        Task Update(Product product);
        Task Delete(int id);
    }
}
