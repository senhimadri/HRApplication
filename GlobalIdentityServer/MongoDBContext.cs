using GlobalIdentityServer.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace GlobalIdentityServer;

public class MongoDBContext
{
    private readonly IMongoDatabase _database;

    public MongoDBContext(IMongoClient client, IOptions<MongoDbSettings> settings)
    {
        _database = client.GetDatabase(settings.Value.DatabaseName);
    }

    public IMongoCollection<UserInformation> UserInformation => _database.GetCollection<UserInformation>("UserInformation");
}
