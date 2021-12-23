namespace AdapterMethod;

public class OldEmailService
{
    public string GetOldEmail(bool isOld = true)
    {
        return isOld ? "This is from OLD email service.#" : "#" ;
    }
}