using FluentValidation;
using FluentValidation.Results;

namespace HRApplication.Application.Helper;

public static class ValidationExtensions
{
    public static Dictionary<string, string[]> ToValidationErrorList(this ValidationResult validationResult)
    {
        var errors = validationResult.Errors
                   .GroupBy(e => e.PropertyName)
                   .ToDictionary(
                       group => group.Key,
                       group => group.Select(e => e.ErrorMessage).ToArray());

        return errors;
    }

    public static async Task<ValidationResult> ValidateAndReturnResultAsync<T>(this IValidator<T> validator, T instance)
    {
        return await validator.ValidateAsync(instance);
    }
}
