using GlobalIdentityServer.IRepository;
using GlobalIdentityServer.Models;
using MongoDB.Driver;

namespace GlobalIdentityServer.Repository;

public class UserRepository(IMongoDatabase database, string collectionName)
                    : GenericRepository<TblUser>(database, collectionName), IUserRepository;