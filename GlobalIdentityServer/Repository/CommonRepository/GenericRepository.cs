using GlobalIdentityServer.Models.CommonModel;
using MongoDB.Driver;
using System.Linq.Expressions;

namespace GlobalIdentityServer.Repository.CommonRepository;

public class GenericRepository<T> : IGenericRepository<T> where T : BaseDomain
{
    private readonly IMongoCollection<T> _context;
    private readonly FilterDefinitionBuilder<T> filterBuilder = Builders<T>.Filter;

    public GenericRepository(IMongoDatabase database, string collectionName)
                            => _context = database.GetCollection<T>(collectionName);

    public async Task CreateAsync(T entity)
    {
        await _context.InsertOneAsync(entity);
    }

    public async Task<IReadOnlyCollection<T>> GetAllAsync()
    {
        return await _context.Find(filterBuilder.Empty).ToListAsync();
    }

    public async Task<IReadOnlyCollection<T>> GetAllAsync(Expression<Func<T, bool>> filter)
    {
        return await _context.Find(filter).ToListAsync();
    }

    public async Task<T> GetAsync(Guid id)
    {
        return await _context.Find(x => x.Id == id).FirstOrDefaultAsync();
    }

    public async Task UpdateAsync(T entity)
    {
        await _context.ReplaceOneAsync(filter: x => x.Id == entity.Id , replacement: entity);
    }

    public async Task RemoveAsync(Guid id)
    {
        await _context.DeleteOneAsync(filter: x => x.Id == id);
    }
}
