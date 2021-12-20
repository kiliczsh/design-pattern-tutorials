namespace AbstractFactoryMethod;

public class Table : IAbstractTable
{
    private string FactoryName { get; }
    
    public Table(string factoryName)
    {
        FactoryName = factoryName;
    }

    public string GetProductDetail()
    {
        return FactoryName + " Table";
    }
}