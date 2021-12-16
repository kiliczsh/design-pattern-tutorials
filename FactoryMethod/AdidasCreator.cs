namespace FactoryMethod;

public class AdidasShoeCreator : ShoeCreator
{
    protected override IShoe ShoeFactory()
    {
        return new AdidasShoe();
    }
}