using FluentValidation;
using FluentValidation.Results;
using HRApplication.Application.Results;

namespace HRApplication.Application.Helper;

public static class ValidationResultConverter
{
    public static List<ValidationError> MapToValidationErrorFormat(this FluentValidation.Results.ValidationResult validationResult)
    {
        var result = validationResult.Errors.Select(x => new ValidationError
        {
            PropertyName = x.PropertyName,
            Message = x.ErrorMessage
        }).ToList();

        return result;
    }

    public static async Task<ValidationResult> ValidateAsync<T>(this IValidator<T> validator, T instance)
    {
        return await validator.ValidateAsync(instance);
    }
}
