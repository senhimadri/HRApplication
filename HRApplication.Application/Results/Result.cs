namespace HRApplication.Application.Results;

public class MasterResult
{
    protected MasterResult(bool isSuccess, Error error)
    {
        if (isSuccess && error != Error.None || !isSuccess && error == Error.None)
            throw new ArgumentException("Invalid error.");

        IsSuccess = isSuccess;
        Error = error;
    } 
    public bool IsSuccess { get; }
    public bool IsFailure => !IsSuccess;
    public Error Error { get; }
}

public class Result : MasterResult
{
    public Result(bool isSuccess, Error error, List<ValidationError>? vaidationError = null) : base(isSuccess, error)
    {
        ValidationError = ValidationError;
    }

    List<ValidationError>? ValidationError { get; }

    public static Result Success() => new(true, Error.None);
    public static Result Failure(Error error) => new(false, error);

    public static Result ValidationFailure(List<ValidationError> error) => new(false, Errors.ValidationFailed , error);

    public static implicit operator Result(Error error) => Failure(error);

}

public sealed record ValidationError(string? PropertyName, string? Message);

public class Result<T> : MasterResult
{
    private Result(T? data,bool isSuccess, Error error) : base(isSuccess, error)
    {
        Data = data;
    }

    public T? Data { get;}

    public static Result<T> Success(T data) => new(data, true, Error.None);
    public static  Result<T> Failure(Error error) => new(default, false, error);

    public static implicit operator Result<T>(Error error) => Failure(error);
}

