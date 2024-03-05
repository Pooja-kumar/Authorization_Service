//using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace AuthorizationService.Models
{
    public class UserContext:DbContext
    {
        public UserContext() { }
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=LAPTOP-S1MBOP8B\SQLEXPRESS;Initial Catalog=AuthorizationDb;User ID=sa;Password=pass@2024");
            }
        }
        public DbSet<User> Users { get; set; }
    }
}
