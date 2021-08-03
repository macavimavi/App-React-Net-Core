using Challenge.Clear.Application.Dtos;
using Challenge.Clear.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Challenge.Clear.Core.Domain.Mapper
{
    public class MovieMapper : IMovieMapper
    {
        public Movie Map(MovieRequest element)
        {
            throw new NotImplementedException();
        }

        public MovieRequest Map(Movie element)
        {
            return new MovieRequest()
            {
                MovieId = element.Id,
                MovieName = element.Title,
                GenreId = (int)element.Genre,
                Genre = element.Genre.ToString(),
                //ActorName = string.Join("|", element.Actors?.Select(x => x.Actor.Name))
            };
        }

        public IEnumerable<MovieRequest> Map(IEnumerable<Movie> element)
        {
            List<MovieRequest> movieRequestLsit = new List<MovieRequest>();
            foreach (var item in element)
            {
                movieRequestLsit.Add(Map(item));
            }
            return movieRequestLsit;
        }
    }
}
