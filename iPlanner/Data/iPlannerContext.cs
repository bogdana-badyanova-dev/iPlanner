using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using iPlanner.Models;

namespace iPlanner.Data
{
    public class iPlannerContext : DbContext
    {
        public iPlannerContext (DbContextOptions<iPlannerContext> options)
            : base(options)
        {
        }

        public DbSet<iPlanner.Models.Board> Board { get; set; }

        public DbSet<iPlanner.Models.Card> Card { get; set; }
    }
}
