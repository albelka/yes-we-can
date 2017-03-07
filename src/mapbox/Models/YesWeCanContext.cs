using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace mapbox.Models
{
    public class YesWeCanContext : DbContext
    {
        public YesWeCanContext() { }
        public virtual DbSet<Message> Messages { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=YesWeCan;integrated security = True");
        }

        public YesWeCanContext(DbContextOptions<YesWeCanContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
