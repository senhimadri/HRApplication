namespace HRApplication.Application.Results;

public class Result : MasterResult
{
    public Result(bool isSuccess, Error error, List<ValidationError>? vaidationErrors = null) : base(isSuccess, error)
    {
        ValidationErrors = ValidationErrors;
    }

    List<ValidationError>? ValidationErrors { get; }
    bool IsValidationFailure => ValidationErrors is not null;

    public static Result Success() => new(true, Error.None);
    public static Result Failure(Error error) => new(false, error);
    public static Result ValidationFailure(List<ValidationError> errors) => new(false, Errors.ValidationFailed , errors);

    public static implicit operator Result(Error error) => Failure(error);

}



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

