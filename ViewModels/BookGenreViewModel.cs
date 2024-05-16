using RSWEB.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace RSWEB.ViewModels


{
    public class BookGenreViewModel
    {
        public IList<Book>? Books { get; set; }
        public SelectList? Genres { get; set; }
        public string? BookGenre { get; set; }
        public string? SearchString { get; set; }
        
        public string? AuthorSearchString { get; set; }  
        public IList<Author>? Authors { get; set; }
    }
}