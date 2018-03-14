namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebApplication1.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApplication1.Models.MovieDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebApplication1.Models.MovieDBContext context) => context.Movies.AddOrUpdate(i => i.Title,
          new Movie
          {
              Title = "When Harry Met Sally",
              ReleaseDate = DateTime.Parse("1989-1-11"),
              Genre = "Romantic Comedy",
              Rating = "PG",
              Price = 7.99M
          },

           new Movie
           {
               Title = "Ghostbusters ",
               ReleaseDate = DateTime.Parse("1984-3-13"),
               Genre = "Comedy",
               Price = 8.99M
           },

           new Movie
           {
               Title = "Ghostbusters 2",
               ReleaseDate = DateTime.Parse("1986-2-23"),
               Genre = "Comedy",
               Price = 9.99M
           },

         new Movie
         {
             Title = "Rio Bravo",
             ReleaseDate = DateTime.Parse("1959-4-15"),
             Genre = "Western",
             Price = 3.99M


         }
         );

    }
}



