namespace BuilderMethod;

public class ConcreteNotificationBuilder : INotificationBuilder
{
    private Notification _notification = new();
    
    public ConcreteNotificationBuilder()
    {
        ResetNotifications();
    }

    private void ResetNotifications()
    {
        _notification = new Notification();
    }
    
    public void CreateEmailNotification(string body)
    {
        _notification.AddNotification(body);
    }
        
    public void CreateSmsNotification(string body)
    {
        _notification.AddNotification(body);
    }
        
    public void CreatePushNotification(string body)
    {
        _notification.AddNotification(body);
    }
    
    public Notification GetNotification()
    {
        var result = _notification;

        ResetNotifications();

        return result;
    }
}