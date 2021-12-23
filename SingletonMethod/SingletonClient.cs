namespace  SingletonMethod;

public static class SingletonClient
{
    public static void Test()
    {
        var s1 = Singleton.GetInstance();
        var s2 = Singleton.GetInstance();

        Console.WriteLine(s1 == s2
            ? "Singleton works, both variables contain the same instance."
            : "Singleton failed, variables contain different instances.");
    }
}