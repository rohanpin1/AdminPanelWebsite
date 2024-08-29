using Microsoft.EntityFrameworkCore;

namespace AdminWeb.Models
{
    public class AdminPnlContext : DbContext
    {
        public AdminPnlContext(DbContextOptions<AdminPnlContext> options)
        : base(options)
        {
        }


        public DbSet<Users> Users { get; set; }
        public DbSet<ResponseMessage> ResponseMessages { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Users>()
				.Property(u => u.UserId)
				.HasColumnType("uniqueidentifier")
				.HasDefaultValueSql("NEWID()");
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=ROHAN\\SQLEXPRESS;Database=AdminPnl;Trusted_Connection=True;encrypt=false;");
		}

	}
}
