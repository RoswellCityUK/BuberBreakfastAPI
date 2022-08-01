using BuberBreakfastAPI.Models;
using BuberBreakfastAPI.ServiceErrors;
using ErrorOr;

namespace BuberBreakfastAPI.Services.Breakfasts
{
    public class BreakfastService : IBreakfastService
    {
        private static readonly Dictionary<Guid, Breakfast> _breakfasts = new();

        public ErrorOr<Deleted> DeleteBreakfast(Guid id)
        {
            _breakfasts.Remove(id);

            return Result.Deleted;
        }

        public ErrorOr<UpsertedBreakfast> UpsertBreakfast(Breakfast breakfast)
        {
            var isNewlyCreated = !_breakfasts.ContainsKey(breakfast.Id);
            _breakfasts[breakfast.Id] = breakfast;

            return new UpsertedBreakfast(isNewlyCreated);
        }

        public ErrorOr<Created> CreateBreakfast(Breakfast breakfast)
        {
            _breakfasts.Add(breakfast.Id, breakfast);

            return Result.Created;
        }

        public ErrorOr<Breakfast> GetBreakfast(Guid id)
        {
            if(_breakfasts.TryGetValue(id, out Breakfast breakfast))
            {
                return _breakfasts[id];
            }

            return Errors.Breakfast.NotFound;
        }
    }
}
