using Microsoft.AspNetCore.Mvc.Rendering;
using RSWEB.Models;
namespace RSWEB.ViewModels
{
    public class AuthorViewModel
    {
        public IList<Author> Authors { get; set; }

        public string SearchString { get; set; }

       
    }
}
