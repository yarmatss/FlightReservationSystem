namespace FlightReservationSystem.Adapters;

public class PaymentAdapter : IPaymentProcessor
{
    private ExternalPaymentService _externalService;

    public PaymentAdapter(ExternalPaymentService externalService)
    {
        _externalService = externalService;
    }

    public void ProcessPayment(double amount)
    {
        _externalService.MakePayment(amount);
    }
}