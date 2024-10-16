using FluentValidation.Results;
using HRApplication.Application.Results;

namespace HRApplication.Application.Helper;

public static class ValidationResultConverter
{

    public static List<ValidationError> ConvertValidationResult(this FluentValidation.Results.ValidationResult validationResult)
    {
        var result = validationResult.Errors.Select(x => new ValidationError
        {
            PropertyName = x.PropertyName,
            Message = x.ErrorMessage,
            ErrorCode = x.ErrorCode
        }).ToList();

        return result;
    }
}
