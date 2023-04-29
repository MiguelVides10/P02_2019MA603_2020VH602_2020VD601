using Microsoft.EntityFrameworkCore;

namespace P02_2019MA603_2020VH602_2020VD601.Models
{
    public class casosCovidContext : DbContext
    {
        public casosCovidContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<departamentos> departamentos { get; set; }
        public DbSet<generos> generos { get; set; }
        public DbSet<reportes> reportes { get; set; }
    }
}
