// <auto-generated />
using Challenge.Clear.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Challenge.Clear.Infrastructure.Migrations
{
    [DbContext(typeof(MoviesDbContext))]
    partial class MoviesDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Challenge.Clear.Core.Domain.Entities.MovieActor", b =>
                {
                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<int>("ActorId")
                        .HasColumnType("int");

                    b.HasKey("MovieId", "ActorId");

                    b.HasIndex("ActorId");

                    b.ToTable("MovieActor");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            ActorId = 1
                        },
                        new
                        {
                            MovieId = 2,
                            ActorId = 2
                        },
                        new
                        {
                            MovieId = 3,
                            ActorId = 3
                        },
                        new
                        {
                            MovieId = 4,
                            ActorId = 1
                        },
                        new
                        {
                            MovieId = 4,
                            ActorId = 2
                        },
                        new
                        {
                            MovieId = 5,
                            ActorId = 1
                        },
                        new
                        {
                            MovieId = 5,
                            ActorId = 2
                        },
                        new
                        {
                            MovieId = 5,
                            ActorId = 3
                        });
                });

            modelBuilder.Entity("Challenge.Clear.Domain.Entities.Actor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Actor");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Salma Hayek"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Eiza González"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Yalitza Aparicio"
                        });
                });

            modelBuilder.Entity("Challenge.Clear.Domain.Entities.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Movie");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Genre = "Action",
                            Title = "Movie 01"
                        },
                        new
                        {
                            Id = 2,
                            Genre = "Adventure",
                            Title = "Movie 02"
                        },
                        new
                        {
                            Id = 3,
                            Genre = "Animated",
                            Title = "Movie 03"
                        },
                        new
                        {
                            Id = 4,
                            Genre = "ScienceFiction",
                            Title = "Movie 04"
                        },
                        new
                        {
                            Id = 5,
                            Genre = "Action",
                            Title = "Movie 05"
                        });
                });

            modelBuilder.Entity("Challenge.Clear.Core.Domain.Entities.MovieActor", b =>
                {
                    b.HasOne("Challenge.Clear.Domain.Entities.Actor", "Actor")
                        .WithMany("Movies")
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Challenge.Clear.Domain.Entities.Movie", "Movie")
                        .WithMany("Actors")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Actor");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("Challenge.Clear.Domain.Entities.Actor", b =>
                {
                    b.Navigation("Movies");
                });

            modelBuilder.Entity("Challenge.Clear.Domain.Entities.Movie", b =>
                {
                    b.Navigation("Actors");
                });
#pragma warning restore 612, 618
        }
    }
}
