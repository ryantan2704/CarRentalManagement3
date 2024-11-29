using Microsoft.AspNetCore.Identity;

namespace CarRentalManagement3.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class CarRentalManagement3User : IdentityUser
    {
		public string? FirstName { get; set; }
		public string? LastName { get; set; }
	}
}
