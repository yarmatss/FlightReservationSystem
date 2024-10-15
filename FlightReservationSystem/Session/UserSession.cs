namespace FlightReservationSystem.Session;

public class UserSession
{
    private static UserSession _instance;
    private static readonly object _lock = new object();

    public string Username { get; private set; }
    public bool IsLoggedIn { get; private set; }

    private UserSession() { }

    public static UserSession Instance
    {
        get
        {
            if (_instance == null)
            {
                lock(_lock)
                {
                    if (_instance == null)
                        _instance = new UserSession();
                }
            }
            return _instance;
        }
    }

    public void Login(string username)
    {
        Username = username;
        IsLoggedIn = true;
    }

    public void Logout()
    {
        Username = null;
        IsLoggedIn = false;
    }
}
