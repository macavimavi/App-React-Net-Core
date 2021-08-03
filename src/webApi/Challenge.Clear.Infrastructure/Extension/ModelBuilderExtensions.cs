using Challenge.Clear.Core.Domain.Entities;
using Challenge.Clear.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge.Clear.Infrastructure.Extension
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor>().HasData(
                new Actor { Id = 1, Name = "Salma Hayek" },
                new Actor { Id = 2, Name = "Eiza González" },
                new Actor { Id = 3, Name = "Yalitza Aparicio" }
            );
                     
            modelBuilder.Entity<Movie>(b =>
            {
                b.HasData(
                new Movie { Id = 1, Genre = EnumGenreTypes.Action, Title = "Movie 01" },
                new Movie { Id = 2, Genre = EnumGenreTypes.Adventure, Title = "Movie 02" },
                new Movie { Id = 3, Genre = EnumGenreTypes.Animated, Title = "Movie 03" },
                new Movie { Id = 4, Genre = EnumGenreTypes.ScienceFiction, Title = "Movie 04" },
                new Movie { Id = 5, Genre = EnumGenreTypes.Action, Title = "Movie 05" }
                );
            });

            modelBuilder.Entity<MovieActor>(b =>
            {
                b.HasData(
                    new MovieActor { MovieId = 1, ActorId = 1 },
                    new MovieActor { MovieId = 2, ActorId = 2 },
                    new MovieActor { MovieId = 3, ActorId = 3 },
                    new MovieActor { MovieId = 4, ActorId = 1 },
                    new MovieActor { MovieId = 4, ActorId = 2 },
                    new MovieActor { MovieId = 5, ActorId = 1 },
                    new MovieActor { MovieId = 5, ActorId = 2 },
                    new MovieActor { MovieId = 5, ActorId = 3 }
                );
            });
        }
    }
}
