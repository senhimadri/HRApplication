using GlobalIdentityServer.Models;
using MongoDB.Driver;
using System.Linq.Expressions;

namespace GlobalIdentityServer.Repository;

public class MongoRepository<T>(IMongoDatabase database, string collectionName)
                                                        : IRepository<T> where T : BaseDomain
{
    private readonly IMongoCollection<T> dbCollection = database.GetCollection<T>(collectionName);
    private readonly FilterDefinitionBuilder<T> filterBuilder = Builders<T>.Filter;

    public async Task CreateAsync(T entity) 
    {
        entity.Id = new Guid();
        entity.IsActive = true;
        entity.CreatedAt = DateTime.UtcNow;
        entity.CreatedBy = Guid.Empty;

        await dbCollection.InsertOneAsync(entity);
    } 

    public async Task<IReadOnlyCollection<T>> GetAllAsync()
                                    => await dbCollection.Find(filterBuilder.Empty).ToListAsync();

    public async Task<IReadOnlyCollection<T>> GetAllAsync(Expression<Func<T, bool>> filter)
                                    => await dbCollection.Find(filter).ToListAsync();

    public async Task<T> GetAsync(Guid id)
                                    => await dbCollection.Find(x => x.Id == id).FirstOrDefaultAsync();

    public async Task UpdateAsync(T entity)
    {
        entity.UpdatedAt = DateTime.UtcNow;
        entity.UpdatedBy = Guid.Empty;

        await dbCollection.ReplaceOneAsync(filter: x => x.Id == entity.Id, replacement: entity);
    }

    public async Task RemoveAsync(Guid id)
                                    => await dbCollection.DeleteOneAsync(filter: x => x.Id == id);

    public async Task<bool> IsExist(Expression<Func<T, bool>> filter)
        => await dbCollection.Find(filter).AnyAsync();
}
