using Arena_TierList.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arena_TierList.ArenaTierList.Repository.Context
{
    public class ApplicationDbContext : DbContext
    {

        public DbSet<Hero> Heroes { get; set; }
        public DbSet<Card> Cards { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
