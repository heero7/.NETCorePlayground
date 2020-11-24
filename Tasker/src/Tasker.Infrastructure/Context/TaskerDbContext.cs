using System.Linq;
using Tasker.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Tasker.Infrastructure.Context
{
    public class TaskerDbContext : DbContext
    {
        public TaskerDbContext(DbContextOptions options) : base(options) { }

        public DbSet<TaskItem> TaskItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var entities = modelBuilder
                .Model.GetEntityTypes()
                .SelectMany(e => e.GetProperties()
                                    .Where(p => p.ClrType == typeof(string)));
            foreach (var prop in entities)
                prop.SetColumnType("varchar(150)");
        }
    }
}
