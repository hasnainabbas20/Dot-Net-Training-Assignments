using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVC_Assignment2.Models
{
    public class MoviesContext : DbContext
    {
        public MoviesContext() : base("name=Movies")
        {

        }

        public DbSet<Movies> Movie { get; set; }
    }
}