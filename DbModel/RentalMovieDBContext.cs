using DbModel.Model;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbModel
{
    public class RentalMovieDBContext : IdentityDbContext<ApplicationUser>
    {
        public static string connectionString = "Data Source=127.0.0.1\\Sense; Initial Catalog=RentalMovie; Integrated Security=False; User Id=sa; Password=Sense17*; MultipleActiveResultSets=True";


        public RentalMovieDBContext() : base(connectionString) { }



        public RentalMovieDBContext GetContext()
        {
            return new RentalMovieDBContext();
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MembershipType> MembershipTypes { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Rental> Rentals { get; set; }

    }
}

