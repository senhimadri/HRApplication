namespace HRApplication.Application.Exceptions;

public sealed record Error(int Code, string? Description = null)
{
    public static readonly Error None = new(200,string.Empty);

    public static implicit operator Result(Error error) => Result.Failure(error);
}

public static class Errors
{
    public static readonly Error ThrowContentNotFount = new Error(400,"Content not Found.");
    public static readonly Error ThrowBadRequest = new Error(500,"Bad Request.");
}

public class Result
{
    private Result(bool isSuccess, Error error)
    {
        if (isSuccess && error != Error.None || !isSuccess && error == Error.None)
            throw new ArgumentException("Invalid error.");

        _isSuccess = isSuccess;
        _error = error;
    }
    public bool _isSuccess { get; }
    public bool _isFailure => !_isSuccess;
    public Error _error { get; }

    public static Result Success() => new(true, Error.None);
    public static Result Failure(Error error) => new(false, error);
}
