namespace FlightReservationSystem.Adapters;

public interface IPaymentProcessor
{
    void ProcessPayment(double amount);
}