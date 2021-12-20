namespace AbstractFactoryMethod;

public static class AbstractFactoryClient
{
    public static void CreateProduct()
    {
        Console.WriteLine("Client: Testing client code with the Deco Factory...");
        GetProducts(new DecoFactory());
        Console.WriteLine();

        Console.WriteLine("Client: Testing the same client code with the Modern Factory...");
        GetProducts(new ModernFactory());
        Console.WriteLine();
        
        Console.WriteLine("Client: Testing the same client code with the Victorian Factory...");
        GetProducts(new VictorianFactory());
        Console.WriteLine();
    }

    private static void GetProducts(IAbstractFactory factory)
    {
        var chair = factory.CreateChair();
        var sofa = factory.CreateSofa();
        var table = factory.CreateTable();

        Console.WriteLine(sofa.GetProductDetail());
        Console.WriteLine(table.GetProductDetail());
        Console.WriteLine(chair.GetProductDetail());
    }
}