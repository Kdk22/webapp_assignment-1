using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DataBound.Models;

namespace DataBound.Pages.Admin.Author
{
    public class CreateAuthorModel : PageModel
    {
        public void OnGet()
        {

        }
        public AuthorClass Author { get; set; }
    }
}
