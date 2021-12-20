namespace AbstractFactoryMethod;

public class ModernFactory : IAbstractFactory
{
    public IAbstractChair CreateChair()
    {
        return new Chair("ModernFactory");
    }

    public IAbstractSofa CreateSofa()
    {
        return new Sofa("ModernFactory");
    }

    public IAbstractTable CreateTable()
    {
        return new Table("ModernFactory");
    }
}