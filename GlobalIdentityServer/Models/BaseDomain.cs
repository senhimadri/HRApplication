using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace GlobalIdentityServer.Models;

public class BaseDomain
{
    [BsonId]
    [BsonRepresentation(BsonType.String)]
    public Guid Id { get; set; }


    [BsonRepresentation(BsonType.String)]
    public DateTime CreatedAt { get; set; }

    [BsonRepresentation(BsonType.String)]
    public Guid CreatedBy { get; set; }

    [BsonRepresentation(BsonType.String)]
    public DateTime? UpdatedAt { get; set; }

    [BsonRepresentation(BsonType.String)]
    public Guid? UpdatedBy { get; set; }

    [BsonRepresentation(BsonType.Boolean)]
    public bool IsActive { get; set; }
}
