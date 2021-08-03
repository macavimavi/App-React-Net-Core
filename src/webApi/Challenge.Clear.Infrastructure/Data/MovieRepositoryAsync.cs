using Challenge.Clear.Application.Interfaces.Repositories;
using Challenge.Clear.Domain.Entities;
using Challenge.Clear.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge.Clear.Infrastructure.Data
{
    public class MovieRepositoryAsync : GenericRepositoryAsync<Movie>, IMovieRepositoryAsync
    {
        public MovieRepositoryAsync(MoviesDbContext dbContext) : base(dbContext)
        {
        }
    }
}
