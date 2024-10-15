using FlightReservationSystem.Models;

namespace FlightReservationSystem.Factories;

public abstract class TicketFactory
{
    public abstract Ticket CreateTicket(string flightNumber, double basePrice);
}