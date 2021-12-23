namespace BuilderMethod;

public interface INotificationBuilder
{
    void CreateEmailNotification(string body);
        
    void CreateSmsNotification(string body);
        
    void CreatePushNotification(string body);
}