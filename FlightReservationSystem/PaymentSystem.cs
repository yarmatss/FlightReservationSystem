using FlightReservationSystem.Adapters;

namespace FlightReservationSystem;

public class PaymentSystem
{
    private IPaymentProcessor _paymentProcessor;

    public PaymentSystem(IPaymentProcessor paymentProcessor)
    {
        _paymentProcessor = paymentProcessor;
    }

    public void Pay(double amount)
    {
        _paymentProcessor.ProcessPayment(amount);
    }
}