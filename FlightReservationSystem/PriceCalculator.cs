using FlightReservationSystem.Pricing;

namespace FlightReservationSystem;

public class PriceCalculator
{
    private IPriceStrategy _priceStrategy;

    public void SetPriceStrategy(IPriceStrategy priceStrategy)
    {
        _priceStrategy = priceStrategy;
    }

    public double Calculate(double basePrice)
    {
        return _priceStrategy.CalculatePrice(basePrice);
    }
}