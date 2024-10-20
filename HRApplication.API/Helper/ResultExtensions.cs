using HRApplication.Application.Results;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HRApplication.API.Helper;

public static class ResultExtensions
{
    public static IActionResult Match(this Result result,
        Func<IActionResult> onSuccess,
        Func<ValidationProblemDetails, IActionResult> onValidationFailure,
        Func<OperationError, IActionResult> onFailure)
    {
        return result.IsSuccess ? onSuccess()
            : (result.IsValidationFailure && result.ValidationErrors is not null) ? onValidationFailure(result.ValidationErrors.ToValidationDetails())
            : onFailure(result.Error);
    }


    public static IActionResult Match<Q>(this Result<Q> result,
        Func<Q?, IActionResult> onSuccess,
        Func<OperationError, IActionResult> onFailure)
    {
        return result.IsSuccess
            ? onSuccess(result.Data)
            : onFailure(result.Error);
    }

    public static ValidationProblemDetails ToValidationDetails(this Dictionary<string, string[]> ValidationErrors)
    {
        return new ValidationProblemDetails(ValidationErrors)
        {
            Title = "Validation Failed",
            Status = StatusCodes.Status400BadRequest
        };

    }

}
