using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExtensibleLogger.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            _logger.LogDebug("Hey, this is a DEBUG message.");
            _logger.LogInformation("Hey, this is an INFO message.");
            _logger.LogWarning("Hey, this is a WARNING message.");
            _logger.LogError("Hey, this is an ERROR message.");

            
        }

        public void OnGet()
        {

        }
    }
}
