namespace SingletonMethod;

public class Singleton
{
    private Singleton() { }
    
    private static Singleton? _instance;
    
    public static Singleton GetInstance()
    {
        Console.WriteLine(_instance != null
            ? $"Returning existing instance with current time: {DateTime.Now:yyyy-MM-dd HH:mm:ss.fffffff}"
            : $"Creating new instance at {DateTime.Now:yyyy-MM-dd HH:mm:ss.fffffff}");
        
        return _instance ??= new Singleton();
    }
}