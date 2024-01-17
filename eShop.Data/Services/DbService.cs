using eShop.Data.Contexts;
using Microsoft.EntityFrameworkCore;

namespace eShop.Data.Services;

public class DbService : IDBService
{
    private protected readonly IMapper _mapper;
    private readonly EShopContext _db;
    public DbService(EShopContext db, IMapper mapper)
    {
        _db = db;
        _mapper = mapper;
    }
    public virtual async Task<List<TDto>> GetAsync<TEntity, TDto>()
        where TEntity : class
        where TDto : class
    {
        //IncludeNavigationsFor<TEntity>();
        var entities = await _db.Set<TEntity>().ToListAsync();
        return _mapper.Map<List<TDto>>(entities);
    }
}
