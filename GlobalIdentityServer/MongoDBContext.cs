using GlobalIdentityServer.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace GlobalIdentityServer;

public class MongoDbContext(IMongoClient client, IOptions<MongoDbSettings> settings) 
{
    private readonly IMongoDatabase _database= client.GetDatabase(settings.Value.DatabaseName);
    public IMongoCollection<UserInformation> UserInformation => _database.GetCollection<UserInformation>("UserInformation");
}
