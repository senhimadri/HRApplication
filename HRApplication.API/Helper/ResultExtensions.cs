using HRApplication.Application.Results;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace HRApplication.API.Helper;

public static class ResultExtensions
{
    public static IActionResult Match(this Result result,
        Func<IActionResult> onSuccess,
        Func<List<ValidationError>?, IActionResult> onValidationFailure,
        Func<Error, IActionResult> onFailure)
    {
        return result.IsSuccess ? onSuccess()
            : result.IsValidationFailure ? onValidationFailure(result.ValidationErrors)
            : onFailure(result.Error);
    }


    public static IActionResult Match<Q>(this Result<Q> result,
        Func<Q?, IActionResult> onSuccess,
        Func<Error, IActionResult> onFailure)
    {
        return result.IsSuccess
            ? onSuccess(result.Data)
            : onFailure(result.Error);
    }

}
