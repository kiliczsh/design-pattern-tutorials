namespace BuilderMethod;

public class NotificationDirector
{
    private readonly INotificationBuilder _notificationBuilder;
    
    public NotificationDirector(INotificationBuilder notificationBuilder)
    {
        _notificationBuilder = notificationBuilder;
    }

    public void BuildEmailNotification(string body)
    {
        _notificationBuilder.CreateEmailNotification(body);
    }
        
    public void BuildSmsNotification(string body)
    {
        _notificationBuilder.CreateSmsNotification(body);
    }
    
    public void BuildPushNotification(string body)
    {
        _notificationBuilder.CreatePushNotification(body);
    }
}