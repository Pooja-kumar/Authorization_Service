using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AuthorizationService.Models
{
    public class UserContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=LAPTOP-S1MBOP8B\SQLEXPRESS;Database=AuthorizationService;Trusted_Connection=True;");
            }
        }

        public DbSet<User> Users { get; set; }
    }
}
