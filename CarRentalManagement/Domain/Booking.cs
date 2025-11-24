namespace CarRentalManagement.Domain
{
    public class Booking
    {
        public int Id { get; set; }
        public DateTime DateIn { get; set; }
        public DateTime DateOut { get; set; }
        public int VehicleId { get; set; }
        public int CustomerId { get; set; }
    }
}
