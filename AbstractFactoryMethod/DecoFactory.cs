namespace AbstractFactoryMethod;

public class DecoFactory : IAbstractFactory
{
    public IAbstractChair CreateChair()
    {
        return new Chair("DecoFactory");
    }

    public IAbstractSofa CreateSofa()
    {
        return new Sofa("DecoFactory");
    }

    public IAbstractTable CreateTable()
    {
        return new Table("DecoFactory");
    }
}