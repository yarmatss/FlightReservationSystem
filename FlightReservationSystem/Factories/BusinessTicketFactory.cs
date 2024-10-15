using FlightReservationSystem.Models;

namespace FlightReservationSystem.Factories;

public class BusinessTicketFactory : TicketFactory
{
    public override Ticket CreateTicket(string flightNumber, double basePrice)
    {
        return new BusinessTicket { FlightNumber = flightNumber, BasePrice = basePrice };
    }
}