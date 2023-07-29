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

        public DbSet<AppMovilAPI.Data.Models.Client> Client { get; set; } = default!;
    }
}
