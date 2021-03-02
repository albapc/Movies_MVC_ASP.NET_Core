using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Movies_MVC_ASP.NET_Core.Models
{
    public class MovieGenreViewModel
    {
        public List<Movies> Movies { get; set; }
        public SelectList Genres { get; set; }
        public string MovieGenre { get; set; }
        public string SearchString { get; set; }
    }
}
