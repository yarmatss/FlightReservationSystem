namespace FlightReservationSystem.Observers;

public class User : IObserver
{
    public string Username { get; set; }

    public void Update(Flight flight)
    {
        Console.WriteLine($"User {Username}: Flight {flight.FlightNumber} status changed to {flight.Status}");
    }
}