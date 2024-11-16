namespace HRApplication.GlobalIdentityServer.Results;

public class MasterResult
{
    protected MasterResult(bool isSuccess, OperationError error)
    {
        if (isSuccess && error != OperationError.None || !isSuccess && error == OperationError.None)
            throw new ArgumentException("Invalid error.");

        IsSuccess = isSuccess;
        Error = error;
    }
    public bool IsSuccess { get; }
    public bool IsFailure => !IsSuccess;
    public OperationError Error { get; }
}

