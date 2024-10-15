namespace FlightReservationSystem.Observers;

public class Flight
{
    private List<IObserver> _observers = new List<IObserver>();
    public string FlightNumber { get; set; }
    public string Status { get; private set; }

    public void RegisterObserver(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void UnregisterObserver(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void NotifyObservers()
    {
        foreach(var observer in _observers)
        {
            observer.Update(this);
        }
    }

    public void ChangeStatus(string newStatus)
    {
        Status = newStatus;
        NotifyObservers();
    }
}