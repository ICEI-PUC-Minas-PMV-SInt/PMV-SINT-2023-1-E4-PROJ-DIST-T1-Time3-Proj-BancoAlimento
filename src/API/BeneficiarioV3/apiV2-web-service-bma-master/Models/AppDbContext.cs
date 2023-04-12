using Microsoft.EntityFrameworkCore;

namespace api_web_service_bma.Models
{
    public class AppDbContext : DbContext
       
    {
        public AppDbContext(DbContextOptions options):base (options)
        {

        }

        public DbSet<Beneficiario> Beneficiarios { get; set; }
    }
}
