using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Data
{
    public interface IDataContext
    {
        DbSet<Product> Products { get; set; }
        Task<int> SaveChangeAsync(CancellationToken cancellationToken = default);
    }
}
