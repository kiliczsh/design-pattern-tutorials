namespace AbstractFactoryMethod;

public class Chair : IAbstractChair
{
    private string FactoryName { get; }
    
    public Chair(string factoryName)
    {
        FactoryName = factoryName;
    }

    public string GetProductDetail()
    {
        return FactoryName + " Chair";
    }
}