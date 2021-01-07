using CarBooking.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace CarBooking.Data.Configurations
{
    public class EmployeeConfigConfiguration : IEntityTypeConfiguration<Employee>
    {

        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employees");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.FullName).IsRequired(true);
            builder.Property(x => x.Phone).IsRequired(true);
            builder.Property(x => x.Email).IsRequired(true);
            builder.Property(x => x.Address).IsRequired(true);
            builder.Property(x => x.Avatar).IsRequired(true);
            builder.Property(x => x.Position).IsRequired(true);
            builder.HasOne(x => x.Car).WithMany(x => x.Employees).HasForeignKey(x => x.CarId);
        }
    }
}