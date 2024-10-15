namespace FlightReservationSystem.Pricing;

public class PromotionalPriceStrategy : IPriceStrategy
{
    public double CalculatePrice(double basePrice)
    {
        // Przykładowa logika promocyjna
        return basePrice * 0.9;
    }
}