using Microsoft.EntityFrameworkCore;
using Bastion.Core.Entity;

namespace Bastion.Infrastructure.SQLData
{
    class BastionContext : DbContext
    {
        public BastionContext(DbContextOptions<BastionContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Speaker> Speakers { get; set; }
    }
}
