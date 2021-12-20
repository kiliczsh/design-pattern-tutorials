namespace AbstractFactoryMethod;

public class VictorianFactory : IAbstractFactory
{
    public IAbstractChair CreateChair()
    {
        return new Chair("VictorianFactory");
    }

    public IAbstractSofa CreateSofa()
    {
        return new Sofa("VictorianFactory");
    }

    public IAbstractTable CreateTable()
    {
        return new Table("VictorianFactory");
    }
}