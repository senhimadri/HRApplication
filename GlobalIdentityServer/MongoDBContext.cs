using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace GlobalIdentityServer;

public class MongoDBContext
{
    private readonly IMongoDatabase _database;

    public MongoDBContext(IMongoClient client, IOptions<MongoDBSettings> settings)
    {
        _database = client.GetDatabase(settings.Value.DatabaseName);
    }

    public IMongoCollection<User> Users => _database.GetCollection<User>("Users");
}
