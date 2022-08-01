﻿using ErrorOr;

namespace BuberBreakfastAPI.ServiceErrors
{
    public static class Errors
    {
        public static class Breakfast
        {
            public static Error InvalidName => Error.Validation(
                code: "Breakfast.InvalidName",
                description: $"Breakfast name must be at least {Models.Breakfast.MinNameLength} characters long and at most {Models.Breakfast.MaxNameLength} characters long.");
            public static Error InvalidDescription => Error.Validation(
                code: "Breakfast.InvalidName",
                description: $"Breakfast description must be at least {Models.Breakfast.MinDescriptionLength} characters long and at most {Models.Breakfast.MaximumDescriptionLength} characters long.");
            public static Error NotFound => Error.NotFound(
                code: "Breakfast.NotFound",
                description: "Breakfast Id not found.");
        }
    }
}
