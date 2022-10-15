using etickets.Models;
using Microsoft.AspNetCore.Builder;
namespace etickets.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetRequiredService<AppDbContext>();
                context.Database.EnsureCreated();
                //Cinema
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name="Cinema 1",
                            Logo="http://dotnethow.net/images/cinemas/cinema-1.jpeg",
                            Description="This is the description of the first cinema"
                        }
                    ,
                      new Cinema()
                       {
                            Name="Cinema 2",
                            Logo="http://dotnethow.net/images/cinemas/cinema-2.jpeg",
                            Description="This is the description of the sec2ndond cinema"
                       }
                       ,
                      new Cinema()
                       {
                            Name="Cinema 3",
                            Logo="http://dotnethow.net/images/cinemas/cinema-3.jpeg",
                            Description="This is the description of the 3rd cinema"
                       }
                       ,
                      new Cinema()
                       {
                            Name="Cinema 4",
                            Logo="http://dotnethow.net/images/cinemas/cinema-4.jpeg",
                            Description="This is the description of the 4th cinema"
                       }
                       ,
                      new Cinema()
                       {
                            Name="Cinema 5",
                            Logo="http://dotnethow.net/images/cinemas/cinema-5.jpeg",
                            Description="This is the description of the 5th cinema"
                       }
                    });
                    context.SaveChanges();
                }                
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                    new Actor()
                    {
                        FullName="Actor 1",
                        ProfilePictureURL = "http://dotnethow.net/images/actors/actor-1.jpeg",
                        Bio="This is bio for Actor 2"
                    }
                    ,
                    new Actor()
                    {
                         FullName="Actor 2",
                        ProfilePictureURL = "http://dotnethow.net/images/actors/actor-2.jpeg",
                        Bio="This is bio for Actor 3"
                    }
                    ,
                    new Actor()
                    {
                         FullName="Actor 3",
                        ProfilePictureURL = "http://dotnethow.net/images/actors/actor-3.jpeg",
                        Bio="This is bio for Actor 3"
                    }
                    ,
                    new Actor()
                    {
                         FullName="Actor 4",
                        ProfilePictureURL = "http://dotnethow.net/images/actors/actor-4.jpeg",
                        Bio="This is bio for Actor 4"
                    }
                    ,
                    new Actor()
                    {
                         FullName="Actor 5",
                        ProfilePictureURL = "http://dotnethow.net/images/actors/actor-5.jpeg",
                        Bio="This is bio for Actor 5"
                    }
                      });
                    context.SaveChanges();
                }
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                   {
                    new Producer()
                    {
                     FullName="Producer 1",
                     Bio="This Bio for producer 1",
                     ProfilePictureURL ="http://dotnethow.net/images/producers/producer-1.jpeg"
                    }
                    ,
                    new Producer()
                    {
                     FullName="Producer 2",
                     Bio="This Bio for producer 2",
                     ProfilePictureURL ="http://dotnethow.net/images/producers/producer-2.jpeg"
                    }
                    ,
                    new Producer()
                    {
                     FullName="Producer 3",
                     Bio="This Bio for producer 3",
                     ProfilePictureURL ="http://dotnethow.net/images/producers/producer-3.jpeg"
                    }
                    ,
                    new Producer()
                    {
                     FullName="Producer 4",
                     Bio="This Bio for producer 4",
                     ProfilePictureURL ="http://dotnethow.net/images/producers/producer-4.jpeg"
                    }
                    ,
                    new Producer()
                    {
                     FullName="Producer 5",
                     Bio="This Bio for producer 5",
                     ProfilePictureURL ="http://dotnethow.net/images/producers/producer-5.jpeg"
                    }
                    });
                    context.SaveChanges();
                }
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                {
                    new Movie()
                    {
                        Name="Scoob",
                        ImageURL="http://dotnethow.net/images/movies/movie-1.jpeg",
                        Description ="Desc for movie1",
                        MovieCategory=Enums.MovieCategory.Animation,
                        Price=3.00d,
                        StartDate=DateTime.Now.AddDays(3),
                        EndDate=DateTime.Now.AddDays(8),
                        CinemaId=1,
                        ProducerId=1
                    }
                    ,
                    new Movie()
                    {
                        Name="Race",
                        ImageURL="http://dotnethow.net/images/movies/movie-2.jpeg",
                        Description ="Desc for movie2",
                        MovieCategory=Enums.MovieCategory.Action,
                        Price=3.20d,
                        StartDate=DateTime.Now.AddDays(3),
                        EndDate=DateTime.Now.AddDays(8),
                        CinemaId=2,
                        ProducerId=2
                    }
                    ,
                    new Movie()
                    {
                        Name="Movie3",
                        ImageURL="http://dotnethow.net/images/movies/movie-3.jpeg",
                        Description ="Desc for movie3",
                        MovieCategory =Enums.MovieCategory.Thriller,
                        Price=2.50d,
                        StartDate=DateTime.Now.AddDays(13),
                        EndDate=DateTime.Now.AddDays(18),
                        CinemaId=3,
                        ProducerId=3
                    }
                    ,
                    new Movie()
                    {
                        Name="Movie4",
                        ImageURL="http://dotnethow.net/images/movies/movie-4.jpeg",
                        Description ="Desc for movie4",
                        MovieCategory=Enums.MovieCategory.Adventure,
                        Price=4.20d,
                        StartDate=DateTime.Now.AddDays(20),
                        EndDate=DateTime.Now.AddDays(30),
                        CinemaId=4,
                        ProducerId=4
                    }
                    ,
                    new Movie()
                    {
                        Name="Movie5",
                        ImageURL="http://dotnethow.net/images/movies/movie-5.jpeg",
                        Description ="Desc for movie5",
                        MovieCategory=Enums.MovieCategory.Drama,
                        Price=3.20d,
                        StartDate=DateTime.Now.AddDays(-12),
                        EndDate=DateTime.Now.AddDays(-7),
                        CinemaId=5,
                        ProducerId=5
                    }
                  });
                    context.SaveChanges();
                }
                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            ActorId=1,
                            MovieId=1
                        }
                        ,
                          new Actor_Movie()
                        {
                            ActorId=2,
                            MovieId=2
                        }
                          ,
                          new Actor_Movie()
                        {
                            ActorId=1,
                            MovieId=3
                        }
                          ,
                          new Actor_Movie()
                        {
                            ActorId=1,
                            MovieId=4
                        }
                          ,
                          new Actor_Movie()
                        {
                            ActorId=4,
                            MovieId=5
                        },                        
                          new Actor_Movie()
                        {
                            ActorId=5,
                            MovieId=5
                        }
                    });
                    context.SaveChanges();
                }

            }
        }
    }
}
