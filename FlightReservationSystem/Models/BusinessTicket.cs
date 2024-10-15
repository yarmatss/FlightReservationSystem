namespace FlightReservationSystem.Models;

public class BusinessTicket : Ticket
{
    public override string GetClassType() => "Business";
}