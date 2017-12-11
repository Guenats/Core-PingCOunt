using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PingCount.Models
{
    public class CounterContext : DbContext
    {
        public CounterContext(DbContextOptions<CounterContext> options) : base(options)
        {

        }

        public DbSet<Counter> CounterItems { get; set; }
    }
}
