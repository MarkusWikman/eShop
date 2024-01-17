using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.Data.Services
{
    public interface IDBService
    {
        Task<List<TDto>> GetAsync<TEntity, TDto>()
            where TEntity : class
            where TDto : class;
    }
}
