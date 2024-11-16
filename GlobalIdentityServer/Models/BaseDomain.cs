using MongoDB.Bson.Serialization.Attributes;

namespace GlobalIdentityServer.Models;

public class BaseDomain
{
    [BsonId]
    public Guid Id { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTimeOffset? UpdatedAt { get; set; }
    public Guid? UpdatedBy { get; set; }
    public bool IsActive { get; set; }
}
