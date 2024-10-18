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

