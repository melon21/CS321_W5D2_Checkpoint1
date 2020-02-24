using System;
using CS321_W5D2_BlogAPI.Core.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CS321_W5D2_BlogAPI.Infrastructure.Data
{
    public class AppDbContext : IdentityDbContext
    {
        // TODO: create Blogs, Posts, and Comments DbSets
        public string Blogs {get; set;}
        public string Posts {get;set;}
        public string Comments {get;set;}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // TODO: use Sqlite db
            DataSource=../CS321_W5D2_BlogAPI.Infrastructure/blog.db;
        }
    }
}
