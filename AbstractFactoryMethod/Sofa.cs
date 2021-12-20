namespace AbstractFactoryMethod;

public class Sofa : IAbstractSofa
{
    private string FactoryName { get; }
    
    public Sofa(string factoryName)
    {
        FactoryName = factoryName;
    }

    public string GetProductDetail()
    {
        return FactoryName + " Sofa";
    }
}