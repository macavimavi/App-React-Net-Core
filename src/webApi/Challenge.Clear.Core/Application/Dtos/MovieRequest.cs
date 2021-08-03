using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge.Clear.Application.Dtos
{
    public class MovieRequest
    {
        public int MovieId { get; set; }

        public string MovieName { get; set; }

        public int GenreId { get; set; }

        public string Genre { get; set; }

        public string ActorName { get; set; }
    }
}
