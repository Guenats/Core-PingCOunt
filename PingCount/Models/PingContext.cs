using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PingCount.Models
{
    public class PingContext : DbContext
    {
        public PingContext(DbContextOptions<PingContext> options) : base(options)
        {

        }

        public DbSet<Ping> PingItems { get; set; }
    }
}
