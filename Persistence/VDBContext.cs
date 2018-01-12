using Microsoft.EntityFrameworkCore;
using asp_core_angular.Models;

namespace asp_core_angular.Persistence
{
    public class VDBContext : DbContext
    {
        public VDBContext(DbContextOptions<VDBContext> options) : base(options)
        {
        }

        public DbSet<Make> Makes { get; set; }

        public DbSet<Model> Models { get; set; }
    }
}