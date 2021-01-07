using CarBooking.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace CarBooking.Data.Configurations
{
    public class TicketConfigConfiguration : IEntityTypeConfiguration<Ticket>
    {

        public void Configure(EntityTypeBuilder<Ticket> builder)
        {
            builder.ToTable("Tickets");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Price).IsRequired(true);
            builder.Property(x => x.Phone).IsRequired(true);
            builder.Property(x => x.Name).IsRequired(true);
            builder.Property(x => x.Address).IsRequired(true);

            builder.HasOne(x => x.User).WithMany(x => x.Tickets).HasForeignKey(x => x.UserId);

            builder.HasOne(x => x.Route).WithMany(x => x.Tickets).HasForeignKey(x => x.RouteId);

            builder.HasOne(x => x.Car).WithMany(x => x.Tickets).HasForeignKey(x => x.CarId);

        }
    }
}