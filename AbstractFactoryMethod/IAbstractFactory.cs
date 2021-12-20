namespace AbstractFactoryMethod
{
    public interface IAbstractFactory
    {
        IAbstractChair CreateChair();
        IAbstractSofa CreateSofa();
        IAbstractTable CreateTable();
    }
}