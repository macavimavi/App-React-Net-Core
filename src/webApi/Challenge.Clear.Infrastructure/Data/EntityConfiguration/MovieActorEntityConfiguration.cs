using Challenge.Clear.Core.Domain.Entities;
using Challenge.Clear.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace Challenge.Clear.Infrastructure.Data.EntityConfiguration
{
  public class MovieActorEntityConfiguration : IEntityTypeConfiguration<MovieActor>
    {
        public void Configure(EntityTypeBuilder<MovieActor> builder)
        {
            builder.ToTable("MovieActor");

            builder.HasKey(s => new { s.MovieId, s.ActorId });

            builder.HasOne(c => c.Movie)
                   .WithMany(c => c.MovieActors)
                   .HasForeignKey( c => c.MovieId);


            builder.HasOne(c => c.Actor)
                   .WithMany(c => c.MovieActors)
                   .HasForeignKey(c => c.ActorId);

        }
      
    }
}
