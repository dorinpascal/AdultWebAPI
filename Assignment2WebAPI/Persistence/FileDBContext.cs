using System;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Assignment2WebAPI.Persistence
{
    public class FileDBContext:DbContext
    {
        public DbSet<Adult> Adults { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Job> Jobs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // name of database
            
            optionsBuilder.UseSqlite("Data Source = Assignment.db");
        }
        

    }
}