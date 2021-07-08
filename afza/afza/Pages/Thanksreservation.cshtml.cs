using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace afza.Pages
{
    public class ThanksreservationModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string name { get; set; }

        [BindProperty(SupportsGet = true)]
        public string email { get; set; }

        [BindProperty(SupportsGet = true)]
        public string phone { get; set; }

        [BindProperty(SupportsGet = true)]
        public string tableno { get; set; }

        [BindProperty(SupportsGet = true)]
        public string date { get; set; }

        [BindProperty(SupportsGet = true)]
        public string guest { get; set; }
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
            if (string.IsNullOrWhiteSpace(tableno))
            {
                tableno = "Please select table no";
            }
            if (string.IsNullOrWhiteSpace(date))
            {
                date = "Please select Date";
            }
            if (string.IsNullOrWhiteSpace(guest))
            {
                guest = "Please put guest number";
            }
            return Page();
        }
    }
}
