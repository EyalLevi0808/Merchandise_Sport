using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Merchandise_Sport_master.Models;

namespace Merchandise_Sport_master.Data
{
    public class Merchandise_Sport_masterContext : DbContext
    {
        public Merchandise_Sport_masterContext (DbContextOptions<Merchandise_Sport_masterContext> options)
            : base(options)
        {
        }

        public DbSet<Merchandise_Sport_master.Models.Product> Product { get; set; }

        public DbSet<Merchandise_Sport_master.Models.Category> Category { get; set; }

        public DbSet<Merchandise_Sport_master.Models.User> User { get; set; }

        

        
    }
}
