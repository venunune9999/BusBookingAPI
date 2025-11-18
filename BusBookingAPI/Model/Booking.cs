namespace BusBookingAPI.Model
{
    public class Booking
    {
        public int BookingID { get; set; }
        public int BusID { get; set; }
        public string SeatNo { get; set; }
        public string UserName { get; set; }
        public string Status { get; set; } = "Confirmed";
        public Bus Bus { get; set; }
    }
}
