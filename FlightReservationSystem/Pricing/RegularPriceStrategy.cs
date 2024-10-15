namespace FlightReservationSystem.Pricing;

public class RegularPriceStrategy : IPriceStrategy
{
    public double CalculatePrice(double basePrice)
    {
        // Standardowa cena
        return basePrice;
    }
}