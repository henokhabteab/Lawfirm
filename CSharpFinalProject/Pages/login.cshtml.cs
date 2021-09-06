using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSharpFinalProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;

namespace CSharpFinalProject.Pages
{
    public class loginModel : PageModel
    {
        [BindProperty]
        public UserModels user { get; set; }
        [BindProperty(SupportsGet = true)]
        public string outMessage { get; set; }
        [BindProperty(SupportsGet = true)]
        public string loginError { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid == false)
            {
                return Page();
            }
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=finalproject;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            string sql = "SELECT * FROM [finalproject].[dbo].[users] WHERE email = '"
                + user.email + "'AND password = '" + user.password + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                user.userName = string.Format("{0}", reader[1]);
                user.email = string.Format("{0}", reader[2]);
                user.phone = string.Format("{0}", reader[4]);
                return RedirectToPage("/Profile", new { user.userName, user.email, user.phone});
            }
            else
            {
                loginError = "Email or password not correct";
                return RedirectToPage("/login", new { loginError });
            }
        }
    }
}