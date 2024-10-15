using FlightReservationSystem.Models;

namespace FlightReservationSystem.Factories;

public class FirstClassTicketFactory : TicketFactory
{
    public override Ticket CreateTicket(string flightNumber, double basePrice)
    {
        return new FirstClassTicket { FlightNumber = flightNumber, BasePrice = basePrice };
    }
}