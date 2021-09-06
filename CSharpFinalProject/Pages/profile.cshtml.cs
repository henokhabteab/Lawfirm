using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CSharpFinalProject.Pages
{
    public class profileModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string userName { get; set; }

        [BindProperty(SupportsGet = true)]
        public string email { get; set; }

        [BindProperty(SupportsGet = true)]
        public string phone { get; set; }

        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(userName))
            {
                userName = "user";
            }
            if (string.IsNullOrWhiteSpace(email))
            {
                email = "user@email.com";
            }
            if (string.IsNullOrWhiteSpace(phone))
            {
                phone = "+9999999999";
            }
        }
    }
}
