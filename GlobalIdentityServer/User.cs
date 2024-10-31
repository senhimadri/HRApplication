using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace GlobalIdentityServer;

public class User
{
    public string Id { get; set; }

    public string Name { get; set; }

    public string Email { get; set; }
}
