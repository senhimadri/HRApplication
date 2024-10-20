namespace HRApplication.Application.Results;

public class Result : MasterResult
{
    public Result(bool isSuccess, OperationError error, Dictionary<string, string[]>? vaidationErrors = null) : base(isSuccess, error)
    {
        ValidationErrors = vaidationErrors;
    }

    public Dictionary<string, string[]>? ValidationErrors { get; }
    public bool IsValidationFailure => ValidationErrors is not null && ValidationErrors.Any();

    public static Result Success() => new(true, OperationError.None);
    public static Result Failure(OperationError error) => new(false, error);
    public static Result ValidationFailure(Dictionary<string, string[]> errors) => new(false, Errors.ValidationFailed, errors);

    public static implicit operator Result(OperationError error) => Failure(error);
}



public class Result<T> : MasterResult
{
    private Result(T? data, bool isSuccess, OperationError error) : base(isSuccess, error)
    {
        Data = data;
    }

    public T? Data { get; }

    public static Result<T> Success(T data) => new Result<T>(data, true, OperationError.None);
    public static Result<T> Failure(OperationError error) => new Result<T>(default, false, error);

    public static implicit operator Result<T>(OperationError error) => Failure(error);
    public static implicit operator Result<T>(T data) => Success(data);
}

