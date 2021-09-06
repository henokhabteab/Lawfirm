using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSharpFinalProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CSharpFinalProject.Pages
{
    public class contactReplyModel : PageModel
    {
        [BindProperty]
        public UserModels user { get; set; }
        [BindProperty(SupportsGet = true)]
        public string name { get; set; }
        public void OnGet()
        {
        }
    }
}
