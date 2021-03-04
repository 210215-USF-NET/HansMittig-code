using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ToHModels;

namespace ToHDL
{
    public class HeroDBContext : DbContext
    {
        public HeroDBContext(DbContextOptions options) : base(options)
        {
        }

        protected HeroDBContext()
        {
        }

        public DbSet<Hero> Heroes { get; set; }
        public DbSet<SuperPower> SuperPowers { get; set; }
    }
}
