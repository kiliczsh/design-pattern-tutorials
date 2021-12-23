namespace BuilderMethod;

public static class Builder
{
    public static void BuildNotifications()
    {
        
        var concreteNotificationBuilder = new ConcreteNotificationBuilder();
        var notificationDirector = new NotificationDirector(concreteNotificationBuilder);

        Console.WriteLine("Email notification: ");
        notificationDirector.BuildEmailNotification("Email 1");
        Console.WriteLine(concreteNotificationBuilder.GetNotification().DisplayNotification());

        Console.WriteLine("Sms notification: ");
        notificationDirector.BuildSmsNotification("Sms 1");
        Console.WriteLine(concreteNotificationBuilder.GetNotification().DisplayNotification());
        
        Console.WriteLine("Push notification: ");
        notificationDirector.BuildPushNotification("Push 1");
        Console.WriteLine(concreteNotificationBuilder.GetNotification().DisplayNotification());

        // Remember, the Builder pattern can be used without a Director class.
        Console.WriteLine("Email plus Push notifications: ");
        concreteNotificationBuilder.CreateEmailNotification("Email 2");
        concreteNotificationBuilder.CreatePushNotification("Push 2");
        Console.Write(concreteNotificationBuilder.GetNotification().DisplayNotification());
    }
}