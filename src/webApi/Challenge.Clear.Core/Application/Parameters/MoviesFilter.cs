using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge.Clear.Application.Parameters
{
    public class MoviesFilter : RequestParameter
    {
        public string Title { get; set; }

        public string  ActorName { get; set; }

        public int? GenreId { get; set; }

    }
}
