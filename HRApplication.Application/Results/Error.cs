namespace HRApplication.Application.Results;

public sealed record Error(int Code, string? Description = null)
{
    public static readonly Error None = new(200, string.Empty);
}

public  class ValidationError
{
    public string? PropertyName { get; set; }
    public string? Message { get; set; }
    public string? ErrorCode { get; set; }
};

