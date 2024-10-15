namespace FlightReservationSystem.Pricing;

public interface IPriceStrategy
{
    double CalculatePrice(double basePrice);
}