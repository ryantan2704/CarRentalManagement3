
using CarRentalManagement3.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace CarRentalManagement3.Configurations.Entities
{
	public class UserSeed : IEntityTypeConfiguration<CarRentalManagement3User>
	{
		public void Configure(EntityTypeBuilder<CarRentalManagement3User> builder)
		{
			var hasher = new PasswordHasher<CarRentalManagement3User>();
			builder.HasData(
			new CarRentalManagement3User
			{
				Id = "3781efa7-66dc-47f0-860f-e506d04102e4",
				Email = "admin@localhost.com",
				NormalizedEmail = "ADMIN@LOCALHOST.COM",
				FirstName = "Admin",
				LastName = "User",
				UserName = "admin@localhost.com",
				NormalizedUserName = "ADMIN@LOCALHOST.COM",
				PasswordHash = hasher.HashPassword(null, "P@ssword1"),
				EmailConfirmed = true // Set to true, otherwise you won't be able to login
			}
			);
		}
	}
}