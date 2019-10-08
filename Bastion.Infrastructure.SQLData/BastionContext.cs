using Microsoft.EntityFrameworkCore;
using Bastion.Core.Entity;

namespace Bastion.Infrastructure.SQLData
{
    public class BastionContext : DbContext
    {
        public BastionContext(DbContextOptions<BastionContext> opt) : base(opt) { }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
		}

		public DbSet<Speaker> Speakers { get; set; }
	}
}
