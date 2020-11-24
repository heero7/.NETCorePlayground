using Tasker.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Tasker.Infrastructure.Mappings
{
    public class TaskItemMapping : IEntityTypeConfiguration<TaskItem>
    {
        public void Configure(EntityTypeBuilder<TaskItem> builder)
        {
            builder.HasKey(t => t.Id);
            builder
                .Property(t => t.Name)
                .IsRequired();

            builder.ToTable("TaskItem");
        }
    }
}
