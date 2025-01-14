namespace HRApplication.Application.Results;

public static class Errors
{
    public static readonly OperationError ContentNotFound = new OperationError(404, "Content not found.");
    public static readonly OperationError BadRequest = new OperationError(400, "Bad request.");
    public static readonly OperationError InternalServerError = new OperationError(500, "Internal server error.");
    public static readonly OperationError UnauthorizedAccess = new OperationError(401, "Unauthorized access.");
    public static readonly OperationError Forbidden = new OperationError(403, "Forbidden access.");
    public static readonly OperationError ValidationFailed = new OperationError(422, "Validation failed.");
    public static OperationError NewError(int code, string message) => new OperationError(code, message);
}

