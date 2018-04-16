namespace DbModel.Migrations
{
    using DbModel.Model;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DbModel.RentalMovieDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DbModel.RentalMovieDBContext context)
        {
          

            var movies = new List<Movie>
            {
                new Movie { Id = 1, Name = "The 400 Blows" },
                new Movie { Id = 2, Name = "La Haine"  },
                new Movie { Id = 3, Name = "The Godfather" },
                new Movie { Id = 4, Name = "The Godfather" },
                new Movie { Id = 5, Name = "Man Bites Dog" },
            };

            movies.ForEach(s => context.Movies.Add(s));
            context.SaveChanges();


            var membershipType = new List<MembershipType>
            {
                new MembershipType { Id = 1, SignUpFeee = 0, DurationInMonths = 0, DiscountRate = 0 },
                new MembershipType { Id = 2, SignUpFeee = 30, DurationInMonths = 1, DiscountRate = 10 },
                new MembershipType { Id = 3, SignUpFeee = 90, DurationInMonths = 3, DiscountRate = 10 },
                new MembershipType { Id = 4, SignUpFeee = 90, DurationInMonths = 3, DiscountRate = 15 },
                new MembershipType { Id = 5, SignUpFeee = 300, DurationInMonths = 12, DiscountRate = 20 },
            };

            membershipType.ForEach(s => context.MembershipTypes.Add(s));
            context.SaveChanges();

            var customer = new List<Customer>
            {
                new Customer { Id = 1, IsSubscribedToNewsletter = true, Name = "Petrov 1", MembershipTypeId = 1, MembershipType = null },
                new Customer { Id = 2, IsSubscribedToNewsletter = false, Name = "Petrov 2", MembershipTypeId = 2, MembershipType = null },
                new Customer { Id = 3, IsSubscribedToNewsletter = true, Name = "Petrov 3", MembershipTypeId = 3, MembershipType = null },
                new Customer { Id = 4, IsSubscribedToNewsletter = false, Name = "Petrov 4", MembershipTypeId = 4, MembershipType = null },
                new Customer { Id = 5, IsSubscribedToNewsletter = true, Name = "Petrov 5", MembershipTypeId = 5, MembershipType = null },
            };

            customer.ForEach(s => context.Customers.Add(s));
            context.SaveChanges();




        }
    }
}
