using Microsoft.AspNetCore.Mvc.Rendering;
using RSWEB.Models;
using System.Collections.Generic;
namespace RSWEB.ViewModels
{
    public class BookGenresEdit
    {
        public Book? Book { get; set; }
        public IEnumerable<int>? SelectedGenres { get; set; }
        public IEnumerable<SelectListItem>? GenreList { get; set; }

    }
}
