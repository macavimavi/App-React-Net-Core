using Challenge.Clear.Application.Dtos;
using Challenge.Clear.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge.Clear.Core.Domain.Mapper
{
    public interface IMovieMapper
    {
        public Movie Map(MovieRequest element);
        public MovieRequest Map(Movie element);

        public IEnumerable<MovieRequest> Map(IEnumerable<Movie> element);

    }
}
