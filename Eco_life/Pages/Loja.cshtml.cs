using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Eco_life.Pages
{
    public class LojaModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public LojaModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
