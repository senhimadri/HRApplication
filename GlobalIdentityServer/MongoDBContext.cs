using GlobalIdentityServer.Models;
using GlobalIdentityServer.Models.CommonModel;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace GlobalIdentityServer;

public class MongoDbContext(IMongoClient client, IOptions<MongoDbSettings> settings) 
{
    private readonly IMongoDatabase _database= client.GetDatabase(settings.Value.DatabaseName);
    public IMongoCollection<UserInformation> UserInformation => _database.GetCollection<UserInformation>("UserInformation");


    public async Task InsertAsync<T>(T entity, CancellationToken cancellationToken = default) where T : BaseDomain
    {
        entity.Id = new Guid();
        entity.CreatedAt = DateTime.UtcNow;
        entity.CreatedBy = Guid.Empty;
        entity.IsActive = true;

        var collection = _database.GetCollection<T>(typeof(T).Name);
        await collection.InsertOneAsync(entity, null, cancellationToken);
    }

    // Update method that sets metadata fields
    public async Task UpdateAsync<T>(T entity, CancellationToken cancellationToken = default) where T : BaseDomain
    {
        entity.UpdatedAt = DateTime.UtcNow;
        entity.UpdatedBy = Guid.Empty;

        var collection = _database.GetCollection<T>(typeof(T).Name);
        var filter = Builders<T>.Filter.Eq(e => e.Id, entity.Id);
        await collection.ReplaceOneAsync(filter, entity, new ReplaceOptions { IsUpsert = false }, cancellationToken);
    }
}
