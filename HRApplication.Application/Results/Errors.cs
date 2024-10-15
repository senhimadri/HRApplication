namespace HRApplication.Application.Results;

public static class Errors
{
    public static readonly Error ContentNotFound = new Error(404, "Content not found.");
    public static readonly Error BadRequest = new Error(400, "Bad request.");
    public static readonly Error InternalServerError = new Error(500, "Internal server error.");
    public static readonly Error UnauthorizedAccess = new Error(401, "Unauthorized access.");
    public static readonly Error Forbidden = new Error(403, "Forbidden access.");

    public static readonly Error ValidationFailed = new Error(422, "Validation failed.");
}

