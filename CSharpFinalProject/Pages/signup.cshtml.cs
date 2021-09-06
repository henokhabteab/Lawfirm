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
    public class signupModel : PageModel
    {
        [BindProperty]
        public UserModels user { get; set; }
        [BindProperty(SupportsGet = true)]
        public string outMessage { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid == false)
            {
                return Page();
            }

            //connect to db
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=finalproject;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            //prepare insert statement

            string sql = "INSERT INTO [finalproject].[dbo].[users]([userName],[phone],[email],[password])" +
                "VALUES ('" + user.userName +  "','" + user.phone + "','" + user.email + "','" + user.password + "')";

            //execute the command

            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            return RedirectToPage("/profile", new {user.email, user.userName, user.phone});
        }
    }

}