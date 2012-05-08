using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Dal
{
    public class HelloContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Movement> Movements { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<HandHeldUser>().ToTable("HandHeldUsers");
        }
    }
}
