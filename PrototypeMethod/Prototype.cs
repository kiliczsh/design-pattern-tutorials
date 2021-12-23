namespace PrototypeMethod;

public static class Prototype
{
    public static void Test()
    {
        var p1 = new Person(
            42, 
            birthDate: Convert.ToDateTime("1977-01-01"), 
            "Jack Daniels",
            idInfo: new IdInfo(666));
        
        var p2 = p1.ShallowCopy();
        var p3 = p1.DeepCopy();
        
        Console.WriteLine("Original values of p1, p2, p3:");
        p1.DisplayValues("   p1 instance values: ");
        p2.DisplayValues("   p2 instance values:");
        p3.DisplayValues("   p3 instance values:");
        
        
        p1.Age = 32;
        p1.BirthDate = Convert.ToDateTime("1900-01-01");
        p1.Name = "Frank";
        p1.IdInfo.IdNumber = 7878;
        
        Console.WriteLine("\nValues of p1, p2 and p3 after changes to p1:");
        p1.DisplayValues("   p1 instance values: ");
        p2.DisplayValues("   p2 instance values (reference values have changed):");
        p3.DisplayValues("   p3 instance values (everything was kept the same):");
    }

    private static void DisplayValues(this Person p, string intro)
    {
        Console.WriteLine(intro);
        Console.WriteLine($"      Name: {p.Name:s}, Age: {p.Age:d}, BirthDate: {p.BirthDate:MM/dd/yy}\n" +
                          $"      ID#: {p.IdInfo.IdNumber:d}");
    }
}