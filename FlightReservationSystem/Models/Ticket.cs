namespace FlightReservationSystem.Models;

public abstract class Ticket
{
    public string FlightNumber { get; set; }
    public double BasePrice { get; set; }
    public abstract string GetClassType();
}