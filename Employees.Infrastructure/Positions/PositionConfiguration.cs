using Employees.Domain.Positions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Employees.Infrastructure.Positions;

public class PositionConfiguration : IEntityTypeConfiguration<Position>

{
    public void Configure(EntityTypeBuilder<Position> builder)
    {
        builder.HasKey(x => x.Id);

        builder.ToTable("positions");

        builder.Property(x => x.Name).IsRequired();
    }
}
