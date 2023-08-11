using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AppMovilAPI.Data.Models;

namespace AppMovilAPI.Data
{
    public class AppMovilDbContext : DbContext
    {
        public AppMovilDbContext (DbContextOptions<AppMovilDbContext> options)
            : base(options)
        {
        }

        public DbSet<Client> Clients { get; set; } = default!;
        public DbSet<UserRole> UserRoles { get; set; } = default!;
        public DbSet<User> Users { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>().ToTable(nameof(Client));
            modelBuilder.Entity<UserRole>().ToTable(nameof(UserRole));
            modelBuilder.Entity<User>().ToTable(nameof(User));

            base.OnModelCreating(modelBuilder);
        }
    }
}
