using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSharpFinalProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CSharpFinalProject.Pages
{
    public class logoutModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public UserModels user { get; set; }
        public string outMessage { get; set; } = "You have successfully logged out";
        public IActionResult OnGet()
        {
            user.email = null;
            return RedirectToPage("/login", new { outMessage });
        }
    }
}
