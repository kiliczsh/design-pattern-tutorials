namespace FactoryMethod;

public static class Factory
{
    public static void CreateProduct()
    {
        Console.WriteLine("App: Launched with the AdidasShoeCreator.");
        var adidas = new AdidasShoeCreator();
        Produce(adidas);
        
        Console.WriteLine("");
        
        Console.WriteLine("App: Launched with the NikeShoeCreator.");
        var nike = new NikeShoeCreator();
        Produce(nike);
    }

    private static void Produce(ShoeCreator shoeCreator)
    {
        Console.WriteLine("Client: I'm not aware of the creator's class," +
                          "but it still works.\n" + shoeCreator.Produce());
    }
}