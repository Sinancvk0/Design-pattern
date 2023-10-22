using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace DesignPattern.ChaninOfResponsibility.DAL
{
    public class AppDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=SINAN;Database=DesignPattern1;Integrated Security=True;TrustServerCertificate=True");
        }

        public DbSet<CustomerProcess> CustomerProcesses { get; set; }

    }
}
