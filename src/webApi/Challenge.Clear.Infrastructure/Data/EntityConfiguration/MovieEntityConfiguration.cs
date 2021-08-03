using Challenge.Clear.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace Challenge.Clear.Infrastructure.Data.EntityConfiguration
{
  public class MovieEntityConfiguration : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.ToTable("Movie");

            builder.HasKey(s => s.Id);

            builder.Property(p => p.Id)
                   .ValueGeneratedOnAdd();

            builder.Property(p => p.Title)
                    .HasMaxLength(50);

            builder.Property(e => e.Genre)
                   .HasConversion(v => v.ToString(),v => (EnumGenreTypes)Enum.Parse(typeof(EnumGenreTypes), v));
        }
      
    }
}
