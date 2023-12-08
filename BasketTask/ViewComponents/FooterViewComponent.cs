using BasketTask.DataAccessLayer;
using Microsoft.AspNetCore.Mvc;

namespace BasketTask.ViewComponents
{
    public class FooterViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;

        public FooterViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(Dictionary<string, string> asdsad)
        {
            //Dictionary<string, string> settings = await _context.Settings.ToDictionaryAsync(s=>s.Key, s => s.Value);

            return View(asdsad);
        }
    }
}
