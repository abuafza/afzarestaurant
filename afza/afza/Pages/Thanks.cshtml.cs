using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace afza.Pages
{
    public class ThanksModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string name { get; set; }

        [BindProperty(SupportsGet = true)]
        public string email { get; set; }

        [BindProperty(SupportsGet = true)]
        public string phone { get; set; }

        [BindProperty(SupportsGet = true)]
        public string message { get; set; }
        public IActionResult OnGet()
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                name = "Your name is missing";
            }
            if (string.IsNullOrWhiteSpace(email))
            {
                email = "Email not provided";
            }
            if (string.IsNullOrWhiteSpace(phone))
            {
                phone = "No Phone number";
            }
            if (string.IsNullOrWhiteSpace(message))
            {
                message = "No more Message";
            }
            return Page();
        }
    }
}
