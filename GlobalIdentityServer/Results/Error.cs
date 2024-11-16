namespace HRApplication.GlobalIdentityServer.Results;

public sealed record OperationError(int Code, string? Description = null)
{
    public static readonly OperationError None = new(200, string.Empty);
}

