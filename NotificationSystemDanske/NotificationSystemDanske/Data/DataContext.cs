using System.Collections.Generic;
using System.Data.Common;
using Microsoft.EntityFrameworkCore;
using NotificationSystemDanske.Models;

namespace Danske.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=DanskeDB;Trusted_Connection=true;TrustServerCertificate=true;");
        }

        public DbSet<Company> Company { get; set; }
        public DbSet<NotificationSystemDanske.Models.Results> Results { get; set; }
    }
}
