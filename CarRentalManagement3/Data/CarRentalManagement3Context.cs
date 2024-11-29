using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CarRentalManagement3.Data;
using CarRentalManagement3.Configurations.Entities;

namespace CarRentalManagement3.Data
{
    public class CarRentalManagement3Context(DbContextOptions<CarRentalManagement3Context> options) : IdentityDbContext<CarRentalManagement3User>(options)
    {
		public DbSet<CarRentalManagement3.Domain.Make> Make { get; set; } = default!;
		public DbSet<CarRentalManagement3.Domain.Model> Model { get; set; } = default!;
		public DbSet<CarRentalManagement3.Domain.Colour> Colour { get; set; } = default!;
		public DbSet<CarRentalManagement3.Domain.Vehicle> Vehicle { get; set; } = default!;
		public DbSet<CarRentalManagement3.Domain.Booking> Booking { get; set; } = default!;
		public DbSet<CarRentalManagement3.Domain.Customer> Customer { get; set; } = default!;

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);

			builder.ApplyConfiguration(new ColourSeed());
			builder.ApplyConfiguration(new MakeSeed());
			builder.ApplyConfiguration(new ModelSeed());
		}
	}
}
