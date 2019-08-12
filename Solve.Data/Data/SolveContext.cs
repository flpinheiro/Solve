using Microsoft.EntityFrameworkCore;
using Solve.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solve.Data
{
    class SolveContext : DbContext
    {
        public DbSet<IUser> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IUser>(u => 
            {
                u.HasKey(U => U.Login);
                u.Property(U => U.Login).IsRequired();
            });
        }
    }
}
