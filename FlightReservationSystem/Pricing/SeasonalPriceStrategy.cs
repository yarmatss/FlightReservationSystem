namespace FlightReservationSystem.Pricing;

public class SeasonalPriceStrategy : IPriceStrategy
{
    public double CalculatePrice(double basePrice)
    {
        // Przykładowa logika sezonowa
        return basePrice * 1.2;
    }
}