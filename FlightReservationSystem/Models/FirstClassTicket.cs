namespace FlightReservationSystem.Models;

public class FirstClassTicket : Ticket
{
    public override string GetClassType() => "First Class";
}