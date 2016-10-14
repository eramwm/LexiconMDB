namespace LexiconMDB.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using LexiconMDB.Models;
    using LexiconMDB.DAL;

    internal sealed class Configuration : DbMigrationsConfiguration<LexiconMDB.DAL.MovieDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MovieDbContext context)
        {
            context.Movies.AddOrUpdate(
              p => p.Title,
              new Movie { Title = "a" },
              new Movie { Title = "b" },
              new Movie { Title = "c" }
            );
        }
    }
}
