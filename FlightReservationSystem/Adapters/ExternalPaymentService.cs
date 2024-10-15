namespace FlightReservationSystem.Adapters;

public class ExternalPaymentService
{
    public void MakePayment(double amount)
    {
        Console.WriteLine($"External payment of {amount} processed.");
    }
}