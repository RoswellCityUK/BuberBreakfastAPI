using ErrorOr;

namespace BuberBreakfastAPI.ServiceErrors
{
    public static class Errors
    {
        public static class Breakfast
        {
            public static Error NotFound => Error.NotFound(
                code: "Breakfast.NotFound",
                description: "Breakfast Id not found.");
        }
    }
}
