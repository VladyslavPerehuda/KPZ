using System;

public sealed class Authenticator
{
    private static Authenticator _instance;
    private static readonly object _lock = new object();
    public string SessionId { get; private set; }

    private Authenticator()
    {
        SessionId = Guid.NewGuid().ToString();
    }

    public static Authenticator Instance
    {
        get
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Authenticator();
                    }
                }
            }
            return _instance;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Task 3");
        Authenticator auth1 = Authenticator.Instance;
        Authenticator auth2 = Authenticator.Instance;

        Console.WriteLine("Session ID 1: " + auth1.SessionId);
        Console.WriteLine("Session ID 2: " + auth2.SessionId);
        Console.WriteLine(auth1 == auth2 ? "Same instance" : "Different instances");

        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
    }
}