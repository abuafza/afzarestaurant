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
    public class reservationModel : PageModel
    {
        [BindProperty]
        public Reservation reservation { get; set; }
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
                string sql = "INSERT INTO [afza].[dbo].[reservation]([name],[email],[phone],[tableno],[date],[guest]) VALUES ('" + reservation.name + "', '" + reservation.email + "', '" + reservation.phone + "', '" + reservation.tableno + "', '" + reservation.date + "', '" + reservation.guest + "')";
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return RedirectToPage("/Thanksreservation", new { reservation.name, reservation.email, reservation.phone, reservation.tableno, reservation.date, reservation.guest });

            }
        }
    }
}
