using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using afza.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;


namespace afza.Pages
{
    public class contactModel : PageModel
    {
        [BindProperty]
        public Contact contact { get; set; }
        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid == false)
            {
                return Page();
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=afza;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                string sql = "INSERT INTO [afza].[dbo].[Contact]([name],[email],[phone],[message]) VALUES ('" + contact.name + "', '" + contact.email + "', '" + contact.phone + "', '" + contact.message + "')";
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return RedirectToPage("/Thanks", new { contact.name, contact.email, contact.phone, contact.message });

            }
        }
    }
}
