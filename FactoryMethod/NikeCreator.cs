namespace FactoryMethod;

public class NikeShoeCreator : ShoeCreator
{
    protected override IShoe ShoeFactory()
    {
        return new NikeShoe();
    }
}