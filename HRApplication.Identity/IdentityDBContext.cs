using HRApplication.Identity.Domain.Authentication;
using MongoDB.Driver;

namespace HRApplication.Identity;

public class IdentityDBContext
{
    private readonly IMongoDatabase _database;

    public IdentityDBContext(string connectionString, string databaseName)
	{
		var client = new MongoClient(connectionString);
		_database = client.GetDatabase(databaseName);
	}
    public IMongoCollection<UserInfo> UserInfos => _database.GetCollection<UserInfo>("UserInfos");
}
