namespace HRApplication.Application.Results;

public class Result : MasterResult
{
    public Result(bool isSuccess, Error error, List<ValidationError>? vaidationErrors = null) : base(isSuccess, error)
    {
        ValidationErrors = ValidationErrors;
    }

    List<ValidationError>? ValidationErrors { get; }
    bool IsValidationFailure => ValidationErrors is not null && ValidationErrors.Any();

    public static Result Success() => new(true, Error.None);
    public static Result Failure(Error error) => new(false, error);
    public static Result ValidationFailure(List<ValidationError> errors) => new(false, Errors.ValidationFailed, errors);

    public static implicit operator Result(Error error) => Failure(error);
}



public class Result<T> : MasterResult
{
    private Result(T? data, bool isSuccess, Error error) : base(isSuccess, error)
    {
        Data = data;
    }

    public T? Data { get; }

    public static Result<T> Success(T data) => new Result<T>(data, true, Error.None);
    public static Result<T> Failure(Error error) => new Result<T>(default, false, error);

    public static implicit operator Result<T>(Error error) => Failure(error);
    public static implicit operator Result<T>(T data) => Success(data);
}

