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
    public class contactusModel : PageModel
    {
        [BindProperty]
        public UserModels user { get; set; }
        
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

            string sql = "INSERT INTO [finalproject].[dbo].[contact]([name],[email],[phone],[caseSubject],[message])" +
                "VALUES ('" + user.name + "','" + user.email + "','" + user.phone + "','" + user.caseSubject + "','" + user.message + "')";

            //execute the command

            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            return RedirectToPage("/contactReply", new { user.name});
        }
    }
}
