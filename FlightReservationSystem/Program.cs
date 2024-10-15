using FlightReservationSystem;
using FlightReservationSystem.Adapters;
using FlightReservationSystem.Factories;
using FlightReservationSystem.Models;
using FlightReservationSystem.Observers;
using FlightReservationSystem.Pricing;
using FlightReservationSystem.Session;

class Program
{
    static void Main(string[] args)
    {
        // Inicjalizacja systemu
        var userSession = UserSession.Instance;
        userSession.Login("JohnDoe");

        // Tworzenie lotu
        var flight = new Flight { FlightNumber = "AB123" };
        
        // Dodanie użytkownika jako obserwatora
        var user = new User { Username = userSession.Username };
        flight.RegisterObserver(user);

        // Tworzenie biletu za pomocą Factory Method
        TicketFactory factory = new EconomyTicketFactory();
        Ticket ticket = factory.CreateTicket(flight.FlightNumber, 100.0);

        // Obliczanie ceny za pomocą Strategy
        var priceCalculator = new PriceCalculator();
        priceCalculator.SetPriceStrategy(new SeasonalPriceStrategy());
        double finalPrice = priceCalculator.Calculate(ticket.BasePrice);
        Console.WriteLine($"Final Price: {finalPrice}");

        // Integracja z systemem płatności za pomocą Adapter
        var externalPaymentService = new ExternalPaymentService();
        var paymentAdapter = new PaymentAdapter(externalPaymentService);
        var paymentSystem = new PaymentSystem(paymentAdapter);
        paymentSystem.Pay(finalPrice);

        // Zmiana statusu lotu
        flight.ChangeStatus("Delayed");

        // Wylogowanie użytkownika
        userSession.Logout();
    }
}
