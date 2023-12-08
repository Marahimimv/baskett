using BasketTask.Models;
using BasketTask.ViewModels.BasketVMs;

namespace BasketTask.Interfaces
{
    public interface ILayoutService
    {
        Task<Dictionary<string, string>> GetSettingsAsync();

        Task<List<Category>> GetCategoriesAsync();

        Task<List<BasketVm>> GetBasketsAsync();
    }
}
