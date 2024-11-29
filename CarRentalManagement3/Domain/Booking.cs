namespace CarRentalManagement3.Domain
{
	public class Booking : BaseDomainModel
	{
		public DateTime DateOut { get; set; }

		public DateTime Datein { get; set; }

		public int VehicleId { get; set; }

		public int CustomerId { get; set; }
	}
}
