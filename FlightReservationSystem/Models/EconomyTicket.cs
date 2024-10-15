namespace FlightReservationSystem.Models;

public class EconomyTicket : Ticket
{
    public override string GetClassType() => "Economy";
}