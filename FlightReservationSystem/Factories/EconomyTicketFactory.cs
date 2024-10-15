using FlightReservationSystem.Models;

namespace FlightReservationSystem.Factories;

public class EconomyTicketFactory : TicketFactory
{
    public override Ticket CreateTicket(string flightNumber, double basePrice)
    {
        return new EconomyTicket { FlightNumber = flightNumber, BasePrice = basePrice };
    }
}