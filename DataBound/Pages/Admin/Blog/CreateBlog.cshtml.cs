using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DataBound.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DataBound.Pages.Admin.Blog
{
    public class CreateBlogModel : PageModel
    {
        public BlogClass Blog { get; set; } = new BlogClass();

        private List<AuthorClass> AuthorLists = new List<AuthorClass>();

        public IEnumerable<SelectListItem> AuthorList { get; set; }

        public CreateBlogModel()
        {
            AuthorClass jack = new AuthorClass()
            {
                FirstName = "Jack",
                LastName = "David",
                BirthDate = new DateTime(1996, 10, 20),
                Email = "david@gmail.com",
                WebsiteAddress = "www.david.com",
                TelephoneNumber = "023820983420",
                Country = "UK",
                Province = "London",
                PostalCode = "44600"
            };

            AuthorClass numan = new AuthorClass()
            {
                FirstName = "Numan",
                LastName = "Laka",
                BirthDate = new DateTime(1996, 10, 20),
                Email = "david@gmail.com",
                WebsiteAddress = "www.david.com",
                TelephoneNumber = "023820983420",
                Country = "UK",
                Province = "London",
                PostalCode = "LO100"
            };
            AuthorClass laeman = new AuthorClass()
            {
                FirstName = "Layman",
                LastName = "Maka",
                BirthDate = new DateTime(1996, 10, 20),
                Email = "david@gmail.com",
                WebsiteAddress = "www.david.com",
                TelephoneNumber = "023820983420",
                Country = "UK",
                Province = "London",
                PostalCode = "41C70"
            };
            AuthorLists.Add(jack);
            AuthorLists.Add(numan);
            AuthorLists.Add(laeman);
        }

        public void OnGet()
        {
            AuthorList = AuthorLists.Select(author => new SelectListItem($"{author.FirstName}{author.LastName}", author.Email));
        }
        

    }


}
