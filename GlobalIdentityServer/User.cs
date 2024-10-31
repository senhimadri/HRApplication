using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace GlobalIdentityServer;

public class User
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }

    [BsonElement("Name")]
    public string Name { get; set; }

    [BsonElement("Email")]
    public string Email { get; set; }
}
