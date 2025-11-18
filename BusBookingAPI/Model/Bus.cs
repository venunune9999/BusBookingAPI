namespace BusBookingAPI.Model
{
    public class Bus
    {
        public int BusID { get; set; }
        public string BusName { get; set; }
        public string BusType { get; set; }
        public DateTime Departure { get; set; }
        public DateTime Arrival { get; set; }
        public decimal Price { get; set; }
        public ICollection<Seat> Seats { get; set; }
    }
}
