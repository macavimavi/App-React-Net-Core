using Challenge.Clear.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge.Clear.Domain.Entities
{
    public class Movie : BaseEntity
    {
        public Movie()
        {
            MovieActors = new List<MovieActor>();
        }

        public string Title { get; set; }
        public EnumGenreTypes Genre { get; set; }

        public IList<MovieActor> MovieActors { get; set; }
    }
}
