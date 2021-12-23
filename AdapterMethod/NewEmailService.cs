namespace AdapterMethod;

public class NewEmailService : IEmailService
{
    private readonly OldEmailService _oldEmailService;

    public NewEmailService(OldEmailService oldEmailService)
    {
        _oldEmailService = oldEmailService;
    }

    public string GetEmail()
    {
        return $"This is from NEW email service.{_oldEmailService.GetOldEmail(false)}";
    }
}