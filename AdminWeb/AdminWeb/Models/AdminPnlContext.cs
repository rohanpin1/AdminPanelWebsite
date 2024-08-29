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
    }
}
