namespace BuilderMethod;

public class Notification
{
    private readonly List<object> _listOfNotifications = new();
        
    public void AddNotification(string part)
    {
        _listOfNotifications.Add(part);
    }
    
    public string DisplayNotification() => $"{string.Join(", ", _listOfNotifications).TrimEnd(',', ' ')}\n";
}