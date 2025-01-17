﻿using Microsoft.EntityFrameworkCore;
using MovieBasicMvc.Models;

namespace MovieBasicMvc.Data
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> 
            options) : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryMovie> CategoryMovies { get; set; }
        public DbSet<Comment> Comments { get; set; }

    }
}
