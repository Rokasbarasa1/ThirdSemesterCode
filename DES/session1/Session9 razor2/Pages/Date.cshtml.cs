using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Session9_razor2.Pages
{
    public class DateModel : PageModel
    {
        private readonly ILogger<DateModel> _logger;
        public string Message;

        public DateModel(ILogger<DateModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            Message = "Message from mode";
        }
    }
}