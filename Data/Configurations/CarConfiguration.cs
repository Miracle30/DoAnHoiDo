using CarBooking.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace CarBooking.Data.Configurations
{
    public class CarConfigConfiguration : IEntityTypeConfiguration<Car>
    {

        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.ToTable("Cars");
            builder.HasKey(x => x.Id);
            
            builder.Property(x => x.CarCode).IsRequired(true);
            builder.Property(x => x.Thumbnail).IsRequired(true);
            builder.Property(x => x.SeatNumber).IsRequired(true);
            builder.Property(x => x.SeatNumberRest).IsRequired(true);
            builder.Property(x => x.StatusCar).IsRequired(true);
        }
    }
}