namespace HRApplication.Application.Results;

public class Result(bool isSuccess, OperationError error, Dictionary<string, string[]>? validation = null) 
                            : MasterResult(isSuccess, error)
{
    public readonly Dictionary<string, string[]>? ValidationErrors = validation;
    public bool IsValidationFailure => ValidationErrors is not null && ValidationErrors.Any();
    public static Result Success() => new(true, OperationError.None);
    private static Result Failure(OperationError error) => new(false, error);
    public static Result ValidationFailure(Dictionary<string, string[]> errors) => new(false, Errors.ValidationFailed, errors);
    public static implicit operator Result(OperationError error) => Failure(error);
}



public class Result<T>(T? data, bool isSuccess, OperationError error) : MasterResult(isSuccess, error)
{
    public readonly T? Data = data;
    private static Result<T> Success(T data) => new Result<T>(data, true, OperationError.None);
    private static Result<T> Failure(OperationError error) => new Result<T>(default, false, error);
    public static implicit operator Result<T>(OperationError error) => Failure(error);
    public static implicit operator Result<T>(T data) => Success(data);
}

