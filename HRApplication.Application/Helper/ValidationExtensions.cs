using FluentValidation;
using FluentValidation.Results;
using HRApplication.Application.Results;

namespace HRApplication.Application.Helper;

public static class ValidationExtensions
{
    public static List<ValidationError> ToValidationErrorList(this FluentValidation.Results.ValidationResult validationResult)
    {
        var result = validationResult.Errors.Select(x => new ValidationError
        {
            PropertyName = x.PropertyName,
            Message = x.ErrorMessage
        }).ToList();

        return result;
    }

    public static async Task<ValidationResult> ValidateAndReturnResultAsync<T>(this IValidator<T> validator, T instance)
    {
        return await validator.ValidateAsync(instance);
    }
}
