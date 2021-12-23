namespace AdapterMethod;

public static class EmailClient
{
    public static void Test()
    {
        var oldEmailService = new OldEmailService();
        IEmailService newEmailService = new NewEmailService(oldEmailService);
        
        Console.WriteLine(newEmailService.GetEmail());
        Console.WriteLine(oldEmailService.GetOldEmail());
    }
}