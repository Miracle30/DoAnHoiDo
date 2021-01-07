using CarBooking.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace CarBooking.Data.Configurations
{
    public class RouteConfigConfiguration : IEntityTypeConfiguration<Route>
    {

        public void Configure(EntityTypeBuilder<Route> builder)
        {
            builder.ToTable("Routes");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.StartPoint).IsRequired(true);
            builder.Property(x => x.EndPoint).IsRequired(true);
            builder.Property(x => x.TimeStart).IsRequired(true);
            builder.Property(x => x.TimeEnd).IsRequired(true);
        }
    }
}