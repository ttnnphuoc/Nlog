using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ImplementNLog.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            _logger.LogDebug(1, "Logs Added in Controller");

        }

        public void OnGet()
        {
            _logger.LogInformation("Hello, I have added logs");
        }
    }
}