using CarBooking.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace CarBooking.Data.Configurations
{
    public class CarImageConfigConfiguration : IEntityTypeConfiguration<CarImage>
    {

        public void Configure(EntityTypeBuilder<CarImage> builder)
        {
            builder.ToTable("CarImages");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Url).IsRequired(true);
            builder.Property(x => x.Size).IsRequired(true);
       
            builder.HasOne(x => x.Car).WithMany(x => x.CarImages).HasForeignKey(x => x.CarId);
        }
    }
}