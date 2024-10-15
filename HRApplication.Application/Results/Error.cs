﻿namespace HRApplication.Application.Results;

public sealed record Error(int Code, string? Description = null)
{
    public static readonly Error None = new(200, string.Empty);


}

