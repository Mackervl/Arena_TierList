using Arena_TierList.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arena_TierList.Data
{
    public class Context : DbContext
    {
        public DbSet<Hero> Heroes { get; set; }
        public DbSet<Card> Cards { get; set; }
        public Context(DbContextOptions<Context> options)
        : base(options)
        {
         
        }
    }
}
