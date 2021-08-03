using Challenge.Clear.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace Challenge.Clear.Infrastructure.Data.EntityConfiguration
{
    public class ActorEntityConfiguration : IEntityTypeConfiguration<Actor>
    {
        public void Configure(EntityTypeBuilder<Actor> builder)
        {
            builder.ToTable("Actor");

            builder.HasKey(s => s.Id);

            builder.Property(p => p.Id)
                    .ValueGeneratedOnAdd();

            builder.Property(p => p.Name)
                    .HasMaxLength(50);

        }
    }
}
