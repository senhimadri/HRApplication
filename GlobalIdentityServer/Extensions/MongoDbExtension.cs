using GlobalIdentityServer.Models;
using GlobalIdentityServer.Repository;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace GlobalIdentityServer.Extensions;

public static class MongoDbExtension
{
    public static IServiceCollection AddMongo(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<MongoDbSettings>(
            configuration.GetSection("MongoDbSettings"));

        services.AddSingleton<IMongoDatabase>(s =>
        {
            var mongoSettings = s.GetRequiredService<IOptions<MongoDbSettings>>().Value;
            var connectionString = $"mongodb://{mongoSettings.Username}:{mongoSettings.Password}@{mongoSettings.Host}:{mongoSettings.Port}/?authSource=admin";
            var client = new MongoClient(connectionString);
            return client.GetDatabase(mongoSettings.DatabaseName);
        });

        return services;
    }

    public static IServiceCollection AddMongoRepository<T> (this IServiceCollection services, string collectionName) where T : BaseDomain
    {
        services.AddSingleton<IRepository<T>>(serviceProvider =>
        {
            var database = serviceProvider.GetService<IMongoDatabase>();

            if (database is null)
                throw new InvalidOperationException("IMongoDatabase instance not found. Ensure MongoDB has been properly configured and registered in the service collection.");

            return new MongoRepository<T>(database, collectionName);
        });

        return services;
    }
}
